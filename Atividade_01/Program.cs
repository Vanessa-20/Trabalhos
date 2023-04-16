namespace Atividade_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
            new Manager()
              {
                  Name = "Angela Rodrigues",
                  DateOfBirth = new DateTime(1975, 1, 5),
                  Gender = "Feminino",
                  HireDate = new DateTime(1995, 4, 20),
                  Department = "Administrativo"
              },
            new Supervisor()
              {
                  Name = "Gustavo da Silva",
                  DateOfBirth = new DateTime(2000, 10, 4),
                  Gender = "Masculino",
                  Team = "Montador",
                  Shift = "Noturno"
              },
            new Operator()
              {
                  Name = "Julho da Conceição",
                  DateOfBirth = new DateTime(1997, 9, 5),
                  Gender = "Masculino",
                  JobTitle = "Vendas",
                  Salary = 2500.00m
              },
            new Manager()
              {
                  Name = "Clara Machado",
                  DateOfBirth = new DateTime(1987, 5, 11),
                  Gender = "Feminino",
                  HireDate = new DateTime(2005, 9, 2),
                  Department = "Comercial"
              },
            new Supervisor()
              {
                  Name = "Janaina Gomes",
                  DateOfBirth = new DateTime(1990, 7, 10),
                  Gender = "Feminino",
                  Team = "Marketing",
                  Shift = "Diurno"
              }
            };

            for (int i = 0; i < people.Length; i++)
              {
                  Console.WriteLine($"Pessoa {i + 1}:");
                  Console.WriteLine($"Nome: {people[i].Name}");
                  Console.WriteLine($"Data de nascimento: {people[i].DateOfBirth.ToShortDateString()}");
                  Console.WriteLine($"Gênero: {people[i].Gender}");

              if (people[i] is Manager)
                {
                    Manager Manager = (Manager)people[i];
                    Console.WriteLine($"Data de contratação: {Manager.HireDate.ToShortDateString()}");
                    Console.WriteLine($"Departamento: {Manager.Department}");
                }
                else if (people[i] is Supervisor)
                {
                    Supervisor supervisor = (Supervisor)people[i];
                    Console.WriteLine($"Time: {supervisor.Team}");
                    Console.WriteLine($"Turno: {supervisor.Shift}");
                }
                else if (people[i] is Operator)
                {
                    Operator Operator = (Operator)people[i];
                    Console.WriteLine($"Cargo: {Operator.JobTitle}");
                    Console.WriteLine($"Salário: {Operator.Salary}");
                }

                Console.WriteLine();
            }
        }
        }
        }
