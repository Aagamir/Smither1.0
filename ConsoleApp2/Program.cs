// See https://aka.ms/new-console-template for more information


int counter = 0;
bool winner = true;
string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
string X = "X";
string O = "O";
bool poprawnaLiczba = true;
void Tabelka (string[] board)
{
    Console.WriteLine("________________     ________________");
    Console.WriteLine($"| {board[1]}  | {board[2]}  | {board[3]}  |     | 1  | 2  | 3  |");
    Console.WriteLine("|____|____|____|     |____|____|____|");
    Console.WriteLine($"| {board[4]}  | {board[5]}  | {board[6]}  |     | 4  | 5  | 6  |");
    Console.WriteLine("|____|____|____|     |____|____|____|");
    Console.WriteLine($"| {board[7]}  | {board[8]}  | {board[9]}  |     | 7  | 8  | 9  |");
    Console.WriteLine("|____|____|____|     |____|____|____|");
};
for (int i = 0; i < 9; i++)
{
    string tura = counter % 2 == 0 ? $"{X}" : $"{O}";
    string turaKoncowa = counter % 2 != 0 ? $"{X}" : $"{O}";
    if (board[1] == board[2] && board[2] == board[3] && board[3] != board[0] || board[4] == board[5] && board[5] == board[6] && board[6] != board[0] || board[7] == board[8] && board[8] == board[9] && board[9] != board[0] ||
        board[1] == board[4] && board[4] == board[7] && board[7] != board[0] || board[2] == board[5] && board[5] == board[8] && board[8] != board[0] || board[3] == board[6] && board[6] == board[9] && board[9] != board[0] ||
        board[1] == board[5] && board[5] == board[9] && board[9] != board[0] || board[3] == board[5] && board[5] == board[7] && board[7] != board[0])
    {
        Console.WriteLine("Wygrywa gracz < " + turaKoncowa + " >");
        winner = false;
        break;
    }
    int userInput;
    do
    {
        Tabelka(board);
        poprawnaLiczba = true;
        userInput = int.Parse(Console.ReadLine());
        if (userInput > 9 || userInput <= 0 || board[userInput] != " ")
        {
            Console.Clear();
            poprawnaLiczba = false;
            Console.WriteLine("Zła wartość, podaj jeszcze raz.");
            
        }
    } while (!poprawnaLiczba);
        board[userInput] = tura;
        counter++;
     Console.Clear();       
}
        do
        {   
            Console.WriteLine("REMIS");
            break;
        }
        while (winner);
        Tabelka(board);
    










/*
 * 
 * Console.WriteLine("********************\nGracz nr.1 gra za pomocą 'X'\n \na Gracz nr.2 za pomocą 'O'");
Random r = new Random();
int rInt = r.Next(1, 3);
Console.Write($"********************\nZaczyna gracz {rInt}\n********************\n|tablica do grania|     | Podpowiedź |\nV                 V     V            V\n");

int userInput2 = int.Parse(Console.ReadLine());
//jeżeli input powtórzy się z poprzednimi to wyświetl wiadomośc i powtórz operację
//if (userInput2 == userInput1)
    Console.WriteLine("Nie możesz wybrać już wybranego pola");

switch (userInput2)
{
    case 1:
        polaNaPlanszy[0, 0] = O;
        break;
    case 2:
        polaNaPlanszy[0, 1] = O;
        break;
    case 3:
        polaNaPlanszy[0, 2] = O;
        break;
    case 4:
        polaNaPlanszy[1, 0] = O;
        break;
    case 5:
        polaNaPlanszy[1, 1] = O;
        break;
    case 6:
        polaNaPlanszy[1, 2] = O;
        break;
    case 7:
        polaNaPlanszy[2, 0] = O;
        break;
    case 8:
        polaNaPlanszy[2, 1] = O;
        break;
    case 9:
        polaNaPlanszy[2, 2] = O;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput3 = int.Parse(Console.ReadLine());

switch (userInput3)
{
    case 1:
        polaNaPlanszy[0, 0] = X;
        break;
    case 2:
        polaNaPlanszy[0, 1] = X;
        break;
    case 3:
        polaNaPlanszy[0, 2] = X;
        break;
    case 4:
        polaNaPlanszy[1, 0] = X;
        break;
    case 5:
        polaNaPlanszy[1, 1] = X;
        break;
    case 6:
        polaNaPlanszy[1, 2] = X;
        break;
    case 7:
        polaNaPlanszy[2, 0] = X;
        break;
    case 8:
        polaNaPlanszy[2, 1] = X;
        break;
    case 9:
        polaNaPlanszy[2, 2] = X;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput4 = int.Parse(Console.ReadLine());

switch (userInput4)
{
    case 1:
        polaNaPlanszy[0, 0] = O;
        break;
    case 2:
        polaNaPlanszy[0, 1] = O;
        break;
    case 3:
        polaNaPlanszy[0, 2] = O;
        break;
    case 4:
        polaNaPlanszy[1, 0] = O;
        break;
    case 5:
        polaNaPlanszy[1, 1] = O;
        break;
    case 6:
        polaNaPlanszy[1, 2] = O;
        break;
    case 7:
        polaNaPlanszy[2, 0] = O;
        break;
    case 8:
        polaNaPlanszy[2, 1] = O;
        break;
    case 9:
        polaNaPlanszy[2, 2] = O;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput5 = int.Parse(Console.ReadLine());

switch (userInput5)
{
    case 1:
        polaNaPlanszy[0, 0] = X;
        break;
    case 2:
        polaNaPlanszy[0, 1] = X;
        break;
    case 3:
        polaNaPlanszy[0, 2] = X;
        break;
    case 4:
        polaNaPlanszy[1, 0] = X;
        break;
    case 5:
        polaNaPlanszy[1, 1] = X;
        break;
    case 6:
        polaNaPlanszy[1, 2] = X;
        break;
    case 7:
        polaNaPlanszy[2, 0] = X;
        break;
    case 8:
        polaNaPlanszy[2, 1] = X;
        break;
    case 9:
        polaNaPlanszy[2, 2] = X;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput6 = int.Parse(Console.ReadLine());

switch (userInput6)
{
    case 1:
        polaNaPlanszy[0, 0] = O;
        break;
    case 2:
        polaNaPlanszy[0, 1] = O;
        break;
    case 3:
        polaNaPlanszy[0, 2] = O;
        break;
    case 4:
        polaNaPlanszy[1, 0] = O;
        break;
    case 5:
        polaNaPlanszy[1, 1] = O;
        break;
    case 6:
        polaNaPlanszy[1, 2] = O;
        break;
    case 7:
        polaNaPlanszy[2, 0] = O;
        break;
    case 8:
        polaNaPlanszy[2, 1] = O;
        break;
    case 9:
        polaNaPlanszy[2, 2] = O;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput7 = int.Parse(Console.ReadLine());

switch (userInput7)
{
    case 1:
        polaNaPlanszy[0, 0] = X;
        break;
    case 2:
        polaNaPlanszy[0, 1] = X;
        break;
    case 3:
        polaNaPlanszy[0, 2] = X;
        break;
    case 4:
        polaNaPlanszy[1, 0] = X;
        break;
    case 5:
        polaNaPlanszy[1, 1] = X;
        break;
    case 6:
        polaNaPlanszy[1, 2] = X;
        break;
    case 7:
        polaNaPlanszy[2, 0] = X;
        break;
    case 8:
        polaNaPlanszy[2, 1] = X;
        break;
    case 9:
        polaNaPlanszy[2, 2] = X;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput8 = int.Parse(Console.ReadLine());

switch (userInput8)
{
    case 1:
        polaNaPlanszy[0, 0] = O;
        break;
    case 2:
        polaNaPlanszy[0, 1] = O;
        break;
    case 3:
        polaNaPlanszy[0, 2] = O;
        break;
    case 4:
        polaNaPlanszy[1, 0] = O;
        break;
    case 5:
        polaNaPlanszy[1, 1] = O;
        break;
    case 6:
        polaNaPlanszy[1, 2] = O;
        break;
    case 7:
        polaNaPlanszy[2, 0] = O;
        break;
    case 8:
        polaNaPlanszy[2, 1] = O;
        break;
    case 9:
        polaNaPlanszy[2, 2] = O;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");

int userInput9 = int.Parse(Console.ReadLine());

switch (userInput9)
{
    case 1:
        polaNaPlanszy[0, 0] = X;
        break;
    case 2:
        polaNaPlanszy[0, 1] = X;
        break;
    case 3:
        polaNaPlanszy[0, 2] = X;
        break;
    case 4:
        polaNaPlanszy[1, 0] = X;
        break;
    case 5:
        polaNaPlanszy[1, 1] = X;
        break;
    case 6:
        polaNaPlanszy[1, 2] = X;
        break;
    case 7:
        polaNaPlanszy[2, 0] = X;
        break;
    case 8:
        polaNaPlanszy[2, 1] = X;
        break;
    case 9:
        polaNaPlanszy[2, 2] = X;
        break;
    default:
        Console.WriteLine("Zły numer");
        break;
}
Console.WriteLine("________________     ________________");
Console.WriteLine($"| {polaNaPlanszy[0, 0]}  | {polaNaPlanszy[0, 1]}  | {polaNaPlanszy[0, 2]}  |     | 1  | 2  | 3  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[1, 0]}  | {polaNaPlanszy[1, 1]}  | {polaNaPlanszy[1, 2]}  |     | 4  | 5  | 6  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
Console.WriteLine($"| {polaNaPlanszy[2, 0]}  | {polaNaPlanszy[2, 1]}  | {polaNaPlanszy[2, 2]}  |     | 7  | 8  | 9  |");
Console.WriteLine("|____|____|____|     |____|____|____|");
*/