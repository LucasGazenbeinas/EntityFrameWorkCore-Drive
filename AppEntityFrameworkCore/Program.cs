using System;
using System.Linq;

namespace AppEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppContext())
            {
                var usuario = context.Usuario.ToList();
                Console.WriteLine($"O total de usuários é: {usuario.Count}\n");
                
                foreach (var Usuario in usuario)
                    Console.WriteLine($"ID: {Usuario.ID} \n - Nome: {Usuario.Nome} \n - Sobrenome: {Usuario.Sobrenome} \n");

                Console.WriteLine("= = = = = = = = =\n");

                var tbl_formaPag = context.tbl_FormaPag.ToList();

                Console.WriteLine($"Total formas de pagamento: {tbl_formaPag.Count}\n");

                foreach (var FormaPag in tbl_formaPag)
                    Console.WriteLine($"Forma Pagamento: {FormaPag.FormaPagamento}\n");

                Console.WriteLine("= = = = = = = = =\n");

                var motorist = context.tbl_Motorista.ToList();

                Console.WriteLine($"O total de motoristas é: {motorist.Count}\n");

                foreach (var Motorista in motorist)
                    Console.WriteLine($"ID: {Motorista.ID} \n - Nome: {Motorista.Nome} \n - Preco KM: {Motorista.Precokm} \n");

                Console.WriteLine("= = = = = = = = =\n");

                var corrida = context.Corridas.ToList();

                Console.WriteLine($"O total de corridas é: {corrida.Count}\n");

                foreach (var Corridas in corrida)
                    Console.WriteLine($"ID: {Corridas.ID} \n - Nome: {Corridas.Usuario} \n - Preco KM: {Corridas.Preco} \n - Horario: {Corridas.Horario} \n - Pagamento: {Corridas.Pagamento} \n - Forma de Pagamento: {Corridas.Fpagamento} \n");

                Console.WriteLine("= = = = = = = = =\n");
            }

                Console.ReadKey();
        }
    }
}