//Verificação de Login. Peça usuário e senha e compare com valores pré-definidos.
//Exemplo: usuário = "admin", senha = "1234".
//Se certo → "Acesso permitido", caso contrário → "Acesso negado"

String usuario = "admin";
int senha = 1234;

Console.WriteLine("Digite o nome de usuário: ");
usuario = Console.ReadLine();

Console.WriteLine("Digite a senha: ");
senha = int.Parse(Console.ReadLine());

if  (usuario == "admin" &&  senha == 1234)
{
    Console.WriteLine("Acesso permitido");
}
else
{
    Console.WriteLine("Acesso negado");
    return;
}