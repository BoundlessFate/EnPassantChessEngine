using System.Runtime.Versioning;
using System.Collections;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;
using System.Xml;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Diagnostics;

namespace EnPassantEngine 
    {
    public partial class FrontendForm : Form {
        char[][] dataBoard;
        bool[][] enPassantAvailable;
        Button[][] buttonBoard;
        bool[] kingMoved;
        bool[][] rookMoved;
        Dictionary<string, int> positionsPlayed;
        int movesSincePawnOrCapture;
        // 1 is White, 2 is Black, -1 is waiting on whites promotion, -2 is waiting on blacks promotion
        int curMove = 1;


        public FrontendForm() {
            InitializeComponent();
            OnStartup();
        }

        private void OnStartup() {
            SetupDropdowns();
            CreateBoard();
            DisplayBoard();
        }

        private void SetupDropdowns() {
            whitePlayer.Items.Clear();
            whitePlayer.Items.Add("Human");
            whitePlayer.SelectedIndex = 0;

            blackPlayer.Items.Clear();
            blackPlayer.Items.Add("Human");
            blackPlayer.SelectedIndex = 0;
        }
        private void ResetBoardColors() {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1) {
                        buttonBoard[i][j].BackColor = SystemColors.HighlightText;
                    } else {
                        buttonBoard[i][j].BackColor = SystemColors.AppWorkspace;
                    }
                }
            }
            PromoteQueenButton.BackColor = SystemColors.HighlightText;
            PromoteRookButton.BackColor = SystemColors.AppWorkspace;
            PromoteBishopButton.BackColor = SystemColors.HighlightText;
            PromoteKnightButton.BackColor = SystemColors.AppWorkspace;
        }

        private void DisplayMoves(int row, int col) {
            ArrayList allMoves = getMoves(row, col, false);
            for (int i = 0; i < allMoves.Count; i++) {
                (int, int) curMove = ((int, int))allMoves[i];
                buttonBoard[curMove.Item1][curMove.Item2].BackColor = Color.Green;
            }
        }

        private ArrayList getAllBlackMoves(bool ignoreChecks) {
            ArrayList allMoves = new ArrayList();
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    if (!char.IsUpper(dataBoard[row][col])) allMoves.AddRange(getMoves(row, col, ignoreChecks));
                }
            }
            return allMoves;
        }

        private ArrayList getAllWhiteMoves(bool ignoreChecks) {
            ArrayList allMoves = new ArrayList();
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    if (char.IsUpper(dataBoard[row][col])) allMoves.AddRange(getMoves(row, col, ignoreChecks));
                }
            }
            return allMoves;
        }

        private (int, int) WhiteKingPos() {
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    if (dataBoard[row][col] == 'K') return (row, col);
                }
            }
            return (-1, -1);
        }

        private (int, int) BlackKingPos() {
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    if (dataBoard[row][col] == 'k') return (row, col);
                }
            }
            return (-1, -1);
        }

        private ArrayList getMoves(int row, int col, bool ignoreChecks) {
            ArrayList allMoves = new ArrayList();
            switch (Char.ToLower(dataBoard[row][col])) {
                case ' ':
                    break;
                case 'r':
                    allMoves = getRookMoves(row, col);
                    break;
                case 'n':
                    allMoves = getKnightMoves(row, col);
                    break;
                case 'b':
                    allMoves = getBishopMoves(row, col);
                    break;
                case 'q':
                    allMoves = getQueenMoves(row, col);
                    break;
                case 'k':
                    allMoves = getKingMoves(row, col);
                    break;
                case 'p':
                    allMoves = getPawnMoves(row, col);
                    break;
            }
            if (ignoreChecks) { return allMoves; }
            ArrayList validatedMoves = new ArrayList();
            char[][] originalBoard = dataBoard.Select(inner => inner.ToArray()).ToArray();
            foreach ((int, int) move in allMoves) {
                // Temporarily act out the move
                // If acting on en passant as black
                if (dataBoard[row][col] == 'p' && move.Item2 != col && dataBoard[move.Item1][move.Item2] == ' ') {
                    dataBoard[row][move.Item2] = ' ';
                    // En passant as white
                } else if (dataBoard[row][col] == 'P' && move.Item2 != col && dataBoard[move.Item1][move.Item2] == ' ') {
                    dataBoard[row][move.Item2] = ' ';
                }
                // Performing long castling
                if (dataBoard[row][col] == 'k' && col - move.Item2 == 2) {
                    dataBoard[0][0] = ' '; dataBoard[0][3] = 'r';
                } else if (dataBoard[row][col] == 'K' && col - move.Item2 == 2) {
                    dataBoard[7][0] = ' '; dataBoard[7][3] = 'R';
                }
                // Performing short castling
                if (dataBoard[row][col] == 'k' && col - move.Item2 == -2) {
                    dataBoard[0][7] = ' '; dataBoard[0][5] = 'r';
                } else if (dataBoard[row][col] == 'K' && col - move.Item2 == -2) {
                    dataBoard[7][7] = ' '; dataBoard[7][5] = 'R';
                }
                dataBoard[move.Item1][move.Item2] = dataBoard[row][col];
                dataBoard[row][col] = ' ';

                // Check the opponents moves for any that capture the current players king
                if (char.IsUpper(dataBoard[move.Item1][move.Item2])) {
                    ArrayList blacksResponses = getAllBlackMoves(true);
                    (int, int) whiteKing = WhiteKingPos();
                    bool moveIsGood = true;
                    foreach ((int, int) resp in blacksResponses) {
                        if (resp == whiteKing) { moveIsGood = false; break; }
                    }
                    if (moveIsGood) validatedMoves.Add(move);
                } else {
                    ArrayList whitesResponses = getAllWhiteMoves(true);
                    (int, int) blackKing = BlackKingPos();
                    bool moveIsGood = true;
                    foreach ((int, int) resp in whitesResponses) {
                        if (resp == blackKing) { moveIsGood = false; break; }
                    }
                    if (moveIsGood) validatedMoves.Add(move);
                }
                dataBoard = originalBoard.Select(inner => inner.ToArray()).ToArray();
            }
            // Remove castles if you would be passing through check
            if (dataBoard[row][col] == 'k' && row == 0 && col == 4) {
                if (!validatedMoves.Contains((0,3))) { validatedMoves.Remove((0,2)); }
                if (!validatedMoves.Contains((0,5))) { validatedMoves.Remove((0,6)); }
            }else if (dataBoard[row][col] == 'K' && row == 7 && col == 4) {
                if (!validatedMoves.Contains((7, 3))) { validatedMoves.Remove((7, 2)); }
                if (!validatedMoves.Contains((7, 5))) { validatedMoves.Remove((7, 6)); }
            }
            return validatedMoves;
        }
        private ArrayList getPawnMoves(int row, int col) {
            ArrayList possibleMoves = new ArrayList();
            int dir = 1;
            if (char.IsUpper(dataBoard[row][col])) dir = -1;
            int newRow = row + (1 * dir); int newCol = col;
            // If you can move forward
            if (newRow > -1 && newRow < 8 && dataBoard[newRow][newCol] == ' ') {
                possibleMoves.Add((newRow, newCol));
                newRow = newRow + (1 * dir);
                // Allowing for moving twice on the first move
                if (((row == 1 && dir == 1) || (row == 6 && dir == -1)) && dataBoard[newRow][newCol] == ' ') {
                    possibleMoves.Add((newRow, newCol));
                }
            }
            for (int i = -1; i <= 1; i += 2) {
                newRow = row + (1 * dir); newCol = col + i;
                // Check for bounds diagonially
                if (newRow > -1 && newRow < 8 && newCol > -1 && newCol < 8) {
                    // Check for capture of opposing piece
                    if (dataBoard[newRow][newCol] != ' ' && char.IsUpper(dataBoard[row][col]) != char.IsUpper(dataBoard[newRow][newCol])) {
                        possibleMoves.Add((newRow, newCol));
                    }
                }
            }
            newRow = row;
            // Black en passant checks
            if (dataBoard[row][col] == 'p' && row == 4) {
                for (int i = -1; i <= 1; i+=2) {
                    newCol = col + i;
                    if (newCol < 0 || newCol > 7) continue;
                    if (enPassantAvailable[1][newCol]) {
                        possibleMoves.Add((5, newCol));
                    }
                }
            }
            // White en passant checks
            if (dataBoard[row][col] == 'P' && row == 3) {
                for (int i = -1; i <= 1; i+=2) {
                    newCol = col + i;
                    if (newCol < 0 || newCol > 7) continue;
                    if (enPassantAvailable[0][newCol]) {
                        possibleMoves.Add((2, newCol));
                    }
                }
            }
            return possibleMoves;
        }
        private ArrayList getKnightMoves(int row, int col) {
            ArrayList possibleMoves = new ArrayList();
            for (int dir = 0; dir < 8; dir++) {
                int newRow = row;
                int newCol = col;
                switch (dir) {
                    case 0:
                        newRow -= 2; newCol += 1;
                        break;
                    case 1:
                        newRow -= 2; newCol -= 1;
                        break;
                    case 2:
                        newRow += 2; newCol += 1;
                        break;
                    case 3:
                        newRow += 2; newCol -= 1;
                        break;
                    case 4:
                        newRow -= 1; newCol += 2;
                        break;
                    case 5:
                        newRow -= 1; newCol -= 2;
                        break;
                    case 6:
                        newRow += 1; newCol += 2;
                        break;
                    case 7:
                        newRow += 1; newCol -= 2;
                        break;
                }
                // Skip if out of bounds
                if (newRow < 0 || newRow > 7) continue;
                if (newCol < 0 || newCol > 7) continue;
                if (dataBoard[newRow][newCol] == ' ' ||
                    char.IsUpper(dataBoard[row][col]) != char.IsUpper(dataBoard[newRow][newCol])) {
                    possibleMoves.Add((newRow, newCol));
                }
            }
            return possibleMoves;
        }

        private ArrayList getBishopMoves(int row, int col) {
            ArrayList possibleMoves = new ArrayList();
            for (int dir = 0; dir < 4; dir++) {
                int mulRow = 0; int mulCol = 0;
                switch (dir) {
                    case 0:
                        mulRow = 1; mulCol = 1;
                        break;
                    case 1:
                        mulRow = 1; mulCol = -1;
                        break;
                    case 2:
                        mulRow = -1; mulCol = 1;
                        break;
                    case 3:
                        mulRow = -1; mulCol = -1;
                        break;
                }
                for (int dist = 1; dist < 8; dist++) {
                    int newRow = row + dist * mulRow;
                    int newCol = col + dist * mulCol;
                    if (newRow < 0 || newRow > 7) break;
                    if (newCol < 0 || newCol > 7) break;
                    if (dataBoard[newRow][newCol] == ' ') {
                        possibleMoves.Add((newRow, newCol));
                    } else if (char.IsUpper(dataBoard[row][col]) == char.IsUpper(dataBoard[newRow][newCol])) break;
                    else { possibleMoves.Add((newRow, newCol)); break; }
                }
            }
            return possibleMoves;
        }

        private ArrayList getQueenMoves(int row, int col) {
            ArrayList possibleMoves = new ArrayList();
            for (int dir = 0; dir < 8; dir++) {
                int mulRow = 0; int mulCol = 0;
                switch (dir) {
                    case 0:
                        mulRow = 1; mulCol = 1;
                        break;
                    case 1:
                        mulRow = 1; mulCol = -1;
                        break;
                    case 2:
                        mulRow = -1; mulCol = 1;
                        break;
                    case 3:
                        mulRow = -1; mulCol = -1;
                        break;
                    case 4:
                        mulRow = 0; mulCol = 1;
                        break;
                    case 5:
                        mulRow = 0; mulCol = -1;
                        break;
                    case 6:
                        mulRow = 1; mulCol = 0;
                        break;
                    case 7:
                        mulRow = -1; mulCol = 0;
                        break;
                }
                for (int dist = 1; dist < 8; dist++) {
                    int newRow = row + dist * mulRow;
                    int newCol = col + dist * mulCol;
                    if (newRow < 0 || newRow > 7) break;
                    if (newCol < 0 || newCol > 7) break;
                    if (dataBoard[newRow][newCol] == ' ') {
                        possibleMoves.Add((newRow, newCol));
                    } else if (char.IsUpper(dataBoard[row][col]) == char.IsUpper(dataBoard[newRow][newCol])) break;
                    else { possibleMoves.Add((newRow, newCol)); break; }
                }
            }
            return possibleMoves;
        }

        private ArrayList getRookMoves(int row, int col) {
            ArrayList possibleMoves = new ArrayList();
            for (int dir = 0; dir < 4; dir++) {
                int mulRow = 0; int mulCol = 0;
                switch (dir) {
                    case 0:
                        mulRow = 0; mulCol = 1;
                        break;
                    case 1:
                        mulRow = 0; mulCol = -1;
                        break;
                    case 2:
                        mulRow = 1; mulCol = 0;
                        break;
                    case 3:
                        mulRow = -1; mulCol = 0;
                        break;
                }
                for (int dist = 1; dist < 8; dist++) {
                    int newRow = row + dist * mulRow;
                    int newCol = col + dist * mulCol;
                    if (newRow < 0 || newRow > 7) break;
                    if (newCol < 0 || newCol > 7) break;
                    if (dataBoard[newRow][newCol] == ' ') {
                        possibleMoves.Add((newRow, newCol));
                    } else if (char.IsUpper(dataBoard[row][col]) == char.IsUpper(dataBoard[newRow][newCol])) break;
                    else { possibleMoves.Add((newRow, newCol)); break; }
                }
            }
            return possibleMoves;
        }

        private ArrayList getKingMoves(int row, int col) {
            ArrayList possibleMoves = new ArrayList();
            for (int dir = 0; dir < 8; dir++) {
                int mulRow = 0; int mulCol = 0;
                switch (dir) {
                    case 0:
                        mulRow = 1; mulCol = 1;
                        break;
                    case 1:
                        mulRow = 1; mulCol = -1;
                        break;
                    case 2:
                        mulRow = -1; mulCol = 1;
                        break;
                    case 3:
                        mulRow = -1; mulCol = -1;
                        break;
                    case 4:
                        mulRow = 0; mulCol = 1;
                        break;
                    case 5:
                        mulRow = 0; mulCol = -1;
                        break;
                    case 6:
                        mulRow = 1; mulCol = 0;
                        break;
                    case 7:
                        mulRow = -1; mulCol = 0;
                        break;
                }
                int newRow = row + mulRow;
                int newCol = col + mulCol;
                if (newRow < 0 || newRow > 7) continue;
                if (newCol < 0 || newCol > 7) continue;
                if (dataBoard[newRow][newCol] == ' ') {
                    possibleMoves.Add((newRow, newCol));
                } else if (char.IsUpper(dataBoard[row][col]) != char.IsUpper(dataBoard[newRow][newCol])) {
                    possibleMoves.Add((newRow, newCol));
                }
            }
            // Castle checks
            if ((!kingMoved[0] && (!char.IsUpper(dataBoard[row][col]))) || (!kingMoved[1] && (char.IsUpper(dataBoard[row][col])))) {
                bool[] rooks;
                if (dataBoard[row][col] == 'k') rooks = rookMoved[0];
                else rooks = rookMoved[1];
                // Long castle
                if (dataBoard[row][col - 1] == ' ' && dataBoard[row][col - 2] == ' ' && dataBoard[row][col - 3] == ' ' && !rooks[0]) {
                    possibleMoves.Add((row, col-2));
                }
                // Short castle
                if (dataBoard[row][col + 1] == ' ' && dataBoard[row][col + 2] == ' ' && !rooks[1]) {
                    possibleMoves.Add((row, col+2));
                }
            }
                return possibleMoves;
        }

        private void AddPositionToCount() {
            string cur = string.Concat(dataBoard.SelectMany(row => row));
            if (positionsPlayed.TryGetValue(cur, out int currentCount))
                positionsPlayed[cur] = currentCount + 1;
            else
                positionsPlayed[cur] = 1;
        }

        private void CreateBoard() {
            movesSincePawnOrCapture = 0;
            positionsPlayed = new Dictionary<string, int>();
            dataBoard = [
                [' ',' ',' ',' ',' ','b',' ','k'],
                [' ',' ','p',' ',' ',' ',' ',' '],
                [' ',' ',' ',' ',' ',' ',' ',' '],
                [' ',' ',' ','P',' ',' ',' ',' '],
                [' ',' ',' ',' ',' ',' ',' ',' '],
                [' ',' ',' ',' ',' ',' ',' ',' '],
                ['K',' ',' ',' ',' ',' ',' ',' '],
                [' ',' ',' ',' ',' ',' ',' ',' ']
//                ['r','n','b','q','k','b','n','r'],
//                ['p','p','p','p','p','p','p','p'],
//                [' ',' ',' ',' ',' ',' ',' ',' '],
//                [' ',' ',' ',' ',' ',' ',' ',' '],
//                [' ',' ',' ',' ',' ',' ',' ',' '],
//                [' ',' ',' ',' ',' ',' ',' ',' '],
//                ['P','P','P','P','P','P','P','P'],
//                ['R','N','B','Q','K','B','N','R']

            ];
            AddPositionToCount();
            buttonBoard = new Button[8][];
            char[] files = "abcdefgh".ToCharArray();
            string[] ranks = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight" };
            for (int row = 0; row < 8; row++) {
                buttonBoard[row] = new Button[8];
                for (int col = 0; col < 8; col++) {
                    string buttonName = $"{files[col]}{ranks[7 - row]}Button"; // e.g., aOneButton, hEightButton
                    Control[] matches = this.Controls.Find(buttonName, true);
                    if (matches.Length > 0 && matches[0] is Button btn) {
                        buttonBoard[row][col] = btn;
                    } else {
                        MessageBox.Show($"Error: Could not find button: {buttonName}");
                    }
                }
            }
            enPassantAvailable = [
                [false, false, false, false, false, false, false, false],
                [false, false, false, false, false, false, false, false]
            ];
            kingMoved = [false, false];
            rookMoved = [[false, false], [false, false]];

                        if (dataBoard[0][4] != 'k') kingMoved[0] = true;
            if (dataBoard[7][4] != 'K') kingMoved[1] = true;
        }



        private void DisplayBoard() {
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    switch (dataBoard[row][col]) {
                        case ' ':
                            buttonBoard[row][col].Image = null;
                            break;
                        case 'r':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/black-rook.png");
                            break;
                        case 'n':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/black-knight.png");
                            break;
                        case 'b':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/black-bishop.png");
                            break;
                        case 'q':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/black-queen.png");
                            break;
                        case 'k':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/black-king.png");
                            break;
                        case 'p':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/black-pawn.png");
                            break;
                        case 'R':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/white-rook.png");
                            break;
                        case 'N':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/white-knight.png");
                            break;
                        case 'B':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/white-bishop.png");
                            break;
                        case 'Q':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/white-queen.png");
                            break;
                        case 'K':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/white-king.png");
                            break;
                        case 'P':
                            buttonBoard[row][col].Image = Image.FromFile("./assets/white-pawn.png");
                            break;
                    }
                }
            }
        }

        private void DisplayChecks() {
            if (curMove == 1 || curMove == -1) {
                ArrayList blacksResponses = getAllBlackMoves(true);
                (int, int) whiteKing = WhiteKingPos();
                foreach ((int, int) resp in blacksResponses) {
                    if (resp == whiteKing) { buttonBoard[whiteKing.Item1][whiteKing.Item2].BackColor = Color.Red; break; }
                }
            } else {
                ArrayList whitesResponses = getAllWhiteMoves(true);
                (int, int) blackKing = BlackKingPos();
                foreach ((int, int) resp in whitesResponses) {
                    if (resp == blackKing) { buttonBoard[blackKing.Item1][blackKing.Item2].BackColor = Color.Red; break; }
                }
            }
        }

        private (int, int) CoordinatesToArr(string coords) {
            int col = 0;
            switch (coords[0]) {
                case 'a':
                    col = 0;
                    break;
                case 'b':
                    col = 1;
                    break;
                case 'c':
                    col = 2;
                    break;
                case 'd':
                    col = 3;
                    break;
                case 'e':
                    col = 4;
                    break;
                case 'f':
                    col = 5;
                    break;
                case 'g':
                    col = 6;
                    break;
                case 'h':
                    col = 7;
                    break;
            }
            return ('8' - coords[1], col);
        }

        private (int, int) ButtonToArr(Button b) {
            int row = 0; int col = 0;
            switch (b.Name[0]) {
                case 'a':
                    col = 0;
                    break;
                case 'b':
                    col = 1;
                    break;
                case 'c':
                    col = 2;
                    break;
                case 'd':
                    col = 3;
                    break;
                case 'e':
                    col = 4;
                    break;
                case 'f':
                    col = 5;
                    break;
                case 'g':
                    col = 6;
                    break;
                case 'h':
                    col = 7;
                    break;
            }

            if (((Button)b).Name.Contains("One")) {
                row = 7;
            } else if (((Button)b).Name.Contains("Two")) {
                row = 6;
            } else if (((Button)b).Name.Contains("Three")) {
                row = 5;
            } else if (((Button)b).Name.Contains("Four")) {
                row = 4;
            } else if (((Button)b).Name.Contains("Five")) {
                row = 3;
            } else if (((Button)b).Name.Contains("Six")) {
                row = 2;
            } else if (((Button)b).Name.Contains("Seven")) {
                row = 1;
            } else {
                row = 0;
            }
            return (row, col);
        }

        private void Square_Click(object sender, EventArgs e) {
            if (curMove < 0) return;
            if (selectedPiece.Text == "") {
                // Get the square
                int row = 0;
                if (((Button)sender).Name.Contains("One")) {
                    row = 1;
                } else if (((Button)sender).Name.Contains("Two")) {
                    row = 2;
                } else if (((Button)sender).Name.Contains("Three")) {
                    row = 3;
                } else if (((Button)sender).Name.Contains("Four")) {
                    row = 4;
                } else if (((Button)sender).Name.Contains("Five")) {
                    row = 5;
                } else if (((Button)sender).Name.Contains("Six")) {
                    row = 6;
                } else if (((Button)sender).Name.Contains("Seven")) {
                    row = 7;
                } else {
                    row = 8;
                }
                (int, int) coord = ButtonToArr((Button)sender);
                if (dataBoard[coord.Item1][coord.Item2] == ' ') { ResetBoardColors(); return; }
                if (char.IsUpper(dataBoard[coord.Item1][coord.Item2]) && curMove != 1) { ResetBoardColors(); return; }
                if (!char.IsUpper(dataBoard[coord.Item1][coord.Item2]) && curMove != 2) { ResetBoardColors(); return; }
                selectedPiece.Text = ((Button)sender).Name[0] + row.ToString();
                ResetBoardColors();
                DisplayChecks();
                DisplayMoves(coord.Item1, coord.Item2);
                return;
            }
            // Piece is already selected, so second selection is where you want to move piece to
            (int, int) originalPos = CoordinatesToArr(selectedPiece.Text);
            (int, int) finalPos = ButtonToArr((Button)sender);
            selectedPiece.Text = "";
            if (originalPos == finalPos) { ResetBoardColors(); DisplayChecks(); return; }
            if (buttonBoard[finalPos.Item1][finalPos.Item2].BackColor != Color.Green) { ResetBoardColors(); DisplayChecks(); return; }
            ResetBoardColors();
            DisplayChecks();
            // Allow for en passanting if the piece moved is a pawn by 2 spaces forward
            if (dataBoard[originalPos.Item1][originalPos.Item2] == 'p' && finalPos.Item1 - originalPos.Item1 == 2) {
                enPassantAvailable[0][originalPos.Item2] = true;
            } else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'P' && originalPos.Item1 - finalPos.Item1 == 2) {
                enPassantAvailable[1][originalPos.Item2] = true;
            }
            // If acting on en passant as black
            if (dataBoard[originalPos.Item1][originalPos.Item2] == 'p' && finalPos.Item2 != originalPos.Item2 && dataBoard[finalPos.Item1][finalPos.Item2] == ' ') {
                dataBoard[originalPos.Item1][finalPos.Item2] = ' ';
                enPassantAvailable[1][finalPos.Item2] = false;
                // En passant as white
            } else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'P' && finalPos.Item2 != originalPos.Item2 && dataBoard[finalPos.Item1][finalPos.Item2] == ' ') {
                dataBoard[originalPos.Item1][finalPos.Item2] = ' ';
                enPassantAvailable[0][finalPos.Item2] = false;
            }

            // Forfeit ability to do en passant when player makes a move
            if (char.IsUpper(dataBoard[originalPos.Item1][originalPos.Item2])) {
                for (int i = 0; i < 8; i++) enPassantAvailable[0][i] = false;
            } else {
                for (int i = 0; i < 8; i++) enPassantAvailable[1][i] = false;
            }

            // Castling updates
            if (dataBoard[originalPos.Item1][originalPos.Item2] == 'k') kingMoved[0] = true;
            else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'K') kingMoved[1] = true;
            if (dataBoard[originalPos.Item1][originalPos.Item2] == 'r' && originalPos.Item2 == 0) rookMoved[0][0] = true;
            else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'r' && originalPos.Item2 == 7) rookMoved[0][1] = true;
            else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'R' && originalPos.Item2 == 0) rookMoved[1][0] = true;
            else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'R' && originalPos.Item2 == 7) rookMoved[1][1] = true;


            // Performing long castling
            if (dataBoard[originalPos.Item1][originalPos.Item2] == 'k' && originalPos.Item2 - finalPos.Item2 == 2) {
                dataBoard[0][0] = ' '; dataBoard[0][3] = 'r';
            } else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'K' && originalPos.Item2 - finalPos.Item2 == 2) {
                dataBoard[7][0] = ' '; dataBoard[7][3] = 'R';
            }
            // Performing short castling
            if (dataBoard[originalPos.Item1][originalPos.Item2] == 'k' && originalPos.Item2 - finalPos.Item2 == -2) {
                dataBoard[0][7] = ' '; dataBoard[0][5] = 'r';
            } else if (dataBoard[originalPos.Item1][originalPos.Item2] == 'K' && originalPos.Item2 - finalPos.Item2 == -2) {
                dataBoard[7][7] = ' '; dataBoard[7][5] = 'R';
            }

            // Increment counter or set to 0 for 50 move stalemate
            if (char.ToLower(dataBoard[originalPos.Item1][originalPos.Item2]) == 'p') {
                movesSincePawnOrCapture = 0;
            } else if (dataBoard[finalPos.Item1][finalPos.Item2] != ' ') {
                movesSincePawnOrCapture = 0;
            } else {
                movesSincePawnOrCapture++;
            }

            dataBoard[finalPos.Item1][finalPos.Item2] = dataBoard[originalPos.Item1][originalPos.Item2];
            dataBoard[originalPos.Item1][originalPos.Item2] = ' ';

            // Change move
            if (curMove == 1) curMove = 2;
            else if (curMove == 2) curMove = 1;

            // Promotion handling
            DisplayBoard();
            if (dataBoard[finalPos.Item1][finalPos.Item2] == 'P' && finalPos.Item1 == 0) {
                HighlightPromotes();
                curMove = -1;
                return;
            } else if (dataBoard[finalPos.Item1][finalPos.Item2] == 'p' && finalPos.Item1 == 7) {
                HighlightPromotes();
                curMove = -2;
                return;
            }
            AddPositionToCount();
            ResetBoardColors();
            DisplayChecks();
            CheckEndOfGame();
        }
        private bool PositionImpossible() {
            // No side has pieces
            bool noPieces = true;
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    if (dataBoard[row][col] != 'k' || dataBoard[row][col] != 'K' || dataBoard[row][col] != ' ') noPieces = false;
                }
            }
            int whiteMinor = 0;
            int whiteMajor = 0;
            int blackMinor = 0;
            int blackMajor = 0;
            // Light,black
            bool[] whiteBishops = [false, false];
            bool[] blackBishops = [false, false];
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    switch (dataBoard[row][col]) {
                        case 'k':
                            break;
                        case 'q':
                            blackMajor++;
                            break;
                        case 'r':
                            blackMajor++;
                            break;
                        case 'p':
                            blackMajor++;
                            break;
                        case 'n':
                            blackMinor++;
                            break;
                        case 'b':
                            blackMinor++;
                            blackBishops[(row + col) % 2] = true;
                            break;
                        case 'K':
                            break;
                        case 'Q':
                            whiteMajor++;
                            break;
                        case 'R':
                            whiteMajor++;
                            break;
                        case 'P':
                            whiteMajor++;
                            break;
                        case 'N':
                            whiteMinor++;
                            break;
                        case 'B':
                            whiteMinor++;
                            whiteBishops[(row + col) % 2] = true;
                            break;
                    }
                }
            }
            if (blackMajor + blackMinor + whiteMajor + whiteMinor == 0) return true;
            if (blackMajor == 0 && whiteMajor == 0 && blackMinor + whiteMinor == 1) return true;
            if (blackMajor == 0 && whiteMajor == 0 && blackMinor == 1 && whiteMinor == 1 &&
               ((blackBishops[0] && whiteBishops[0]) || (blackBishops[1] && whiteBishops[1]))) return true;
            return false;
        }

        private void CheckEndOfGame() {
            bool checkmate = false;
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    if (buttonBoard[row][col].BackColor == Color.Red) { checkmate = true; break; }
                }
            }
            if (PositionImpossible()) {
                MessageBox.Show("Stalemate By Insufficient Material");
                return;
            }
            if (movesSincePawnOrCapture >= 50) {
                MessageBox.Show("Stalemate By 50 Move Rule");
                return;
            }
            string curPos = string.Concat(dataBoard.SelectMany(row => row));
            if (positionsPlayed.TryGetValue(curPos, out int currentCount))
                if (positionsPlayed[curPos] >= 3) {
                    MessageBox.Show("Stalemate By Threefold Repetition");
                    return;
                }
            // Check for end of game
            if (curMove == 1 && getAllWhiteMoves(false).Count == 0) {
                if (checkmate) {
                    MessageBox.Show("Black Won By Checkmate");
                } else {
                    MessageBox.Show("Stalemate By Lack Of Moves");
                }
            } else if (curMove == 2 && getAllBlackMoves(false).Count == 0) {
                if (checkmate) {
                    MessageBox.Show("White Won By Checkmate");
                } else {
                    MessageBox.Show("Stalemate By Lack Of Moves");
                }
            }
        }

        private void HighlightPromotes() {
            PromoteQueenButton.BackColor = Color.Green;
            PromoteRookButton.BackColor = Color.Green;
            PromoteBishopButton.BackColor = Color.Green;
            PromoteKnightButton.BackColor = Color.Green;
        }

        private void deselectPieceButton_Click(object sender, EventArgs e) {
            selectedPiece.Text = "";
        }

        private void PromoteButton_Click(object sender, EventArgs e) {
            if (((Button)sender).BackColor == Color.Green) {
                int row = 0; int col = -1;
                for (int i = 0; i < 8; i++) {
                    if (dataBoard[row][i] == 'P') { col = i; break; }
                }
                if (col == -1) {
                    row = 7;
                    for (int i = 0; i < 8; i++) {
                        if (dataBoard[row][i] == 'p') { col = i; break; }
                    }
                }
                switch (((Button)sender).Name) {
                    case "PromoteQueenButton":
                        dataBoard[row][col] = 'q';
                        break;
                    case "PromoteRookButton":
                        dataBoard[row][col] = 'r';
                        break;
                    case "PromoteBishopButton":
                        dataBoard[row][col] = 'b';
                        break;
                    case "PromoteKnightButton":
                        dataBoard[row][col] = 'n';
                        break;
                }
                if (row == 0) dataBoard[row][col] = char.ToUpper(dataBoard[row][col]);
                if (curMove == -1) curMove = 2;
                else curMove = 1;
                AddPositionToCount();
                ResetBoardColors();
                DisplayBoard();
                DisplayChecks();
                CheckEndOfGame();
            }
        }
    }
}
