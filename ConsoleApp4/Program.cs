using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Calculadoras
{
    public static class VariaveisGlobais
    {
        //VARS GLOBAL
        public const double Pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949129833673362440656643086021394946395224737190702179860943702770539217176293176752384674818467669405132000568127145263560827785771342757789609173637178721468440901224953430146549585371050792279689258923542019956112129021960864034418159813629774771309960518707211349999998372978049951059731732816096318595024459455346908302642522308253344685035261931188171010003137838752886587533208381420617177669147303598253490428755468731159562863882353787593751957781857780532171226806613001927876611195909216420198938095257201065485863278865936153381827968230301952035301852968995773622599413891249721775283479131515574857242454150695950829533116861727855889075098381754637464939319255060400927701671139009848824012858361603563707660104710181942955596198946767837449448255379774726847104047534646208046684259069491293313677028989152104752162056966024058038150193511253382430035587640247496473263914199272604269922796782354781636009341721641219924586315030286182974555706749838505494588586926995690927210797509302955321165344987202755960236480665499119881834797753566369807426542527862551818417574672890977772793800081647060016145249192173217214772350141441973568548161361157352552133475741849468438523323907394143334547762416862518983569485562099219222184272550254256887671790494601653466804988627232791786085784383827967976681454100953883786360950680064225125205117392984896084128488626945604241965285022210661186306744278622039194945047123713786960956364371917287467764657573962413890865832645995813390478027590099465764078951269468398352595709825822620522489407726719478268482601476990902640136394437455305068203496252451749399651431429809190659250937221696461515709858387410597885959772975498930161753928468138268683868942774155991855925245953959431049972524680845987273644695848653836736222626099124608051243884390451244136549762780797715691435997700129616089441694868555848406353422072225828488648158456028506016842739452267467678895252138522549954666727823986456596116354886230577456498035593634568174324112515076069479451096596094025228879710893145669136867228748940560101503308617928680920874760917824938589009714909675985261365549781893129784821682998948722658804857564014270477555132379641451523746234364542858444795265867821051141354735739523113427166102135969536231442952484937187110145765403590279934403742007310578539062198387447808478489683321445713868751943506430218453191048481005370614680674919278191197939952061419663428754440643745123718192179998391015919561814675142691239748940907186494231961567945208095146550225231603881930142093762137855956638937787083039069792077346722182562599661501421503068038447734549202605414665925201497442850732518666002132434088190710486331734649651453905796268561005508106658796998163574736384052571459102897064140110971206280439039759515677157700420337869936007230558763176359421873125147120532928191826186125867321579198414848829164470609575270695722091756711672291098169091528017350671274858322287183520935396572512108357915136988209144421006751033467110314126711136990865851639831501970165151168517143765761835155650884909989859982387345528331635507647918535893226185489632132933089857064204675259070915481416549859461637180270981994309924488957571282890592323326097299712084433573265489382391193259746366730583604142813883032038249037589852437441702913276561809377344403070746921120191302033038019762110110044929321516084244485963766983895228684783123552658213144957685726243344189303968642624341077322697802807318915441101044682325271620105265227211166039666557309254711055785376346682065310989652691862056476931257058635662018558100729360659876486117910453348850346113657686753249441668039626579787718556084552965412665408530614344431858676975145661406800700237877659134401712749470420562230538994561314071127000407854733269939081454664645880797270826683063432858785698305235808933065757406795457163775254202114955761581400250126228594130216471550979259230990796547376125517656751357517829666454779;
    }
    class UserInterface
    {
        public static void Main(string[] args)
        {
            Splash();
            Selecao();
        }
        static void Splash()
        {
            Console.WindowWidth = 160;
            Console.WindowHeight = 25;
            Console.WriteLine
(@"
===========================================================================================================================================================
 █████╗ ██████╗ ████████╗██╗   ██╗██████╗  ██████╗███████╗ ██████╗  █████╗     ███████╗ ██████╗ ███████╗████████╗██╗    ██╗ █████╗ ██████╗ ███████╗███████╗
██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██╔══██╗██╔════╝╚════██║██╔════╝ ██╔══██╗    ██╔════╝██╔═══██╗██╔════╝╚══██╔══╝██║    ██║██╔══██╗██╔══██╗██╔════╝██╔════╝
███████║██████╔╝   ██║   ██║   ██║██████╔╝███████╗    ██╔╝███████╗ ╚█████╔╝    ███████╗██║   ██║█████╗     ██║   ██║ █╗ ██║███████║██████╔╝█████╗  ███████╗
██╔══██║██╔══██╗   ██║   ██║   ██║██╔══██╗██╔═══██╗  ██╔╝ ██╔═══██╗██╔══██╗    ╚════██║██║   ██║██╔══╝     ██║   ██║███╗██║██╔══██║██╔══██╗██╔══╝  ╚════██║
██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║╚██████╔╝  ██║  ╚██████╔╝╚█████╔╝    ███████║╚██████╔╝██║        ██║   ╚███╔███╔╝██║  ██║██║  ██║███████╗███████║
╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═════╝  ╚════╝     ╚══════╝ ╚═════╝ ╚═╝        ╚═╝    ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝
===========================================================================================================================================================");
            Console.Beep(800, 500);
            Thread.Sleep(300);
            Console.Clear();
            Console.WindowWidth = 80;
        }
        public static void Selecao()
        {
            //VARS LOCAL
            bool verificar;
            int userout;
            //
            while (true)
            {
                Console.WriteLine("==========================================\n" +
                                   "Qual calculadora deseja utiizar?\n" +
                                           "[1] Pitagoras\n" +
                                      "[2] Volume da esfera\n" +
                                          "[3] Area do circulo\n" +
                                      "[4] Comprimento do circulo\n" +
                              "==========================================");

                Console.Write("Sua escolha: ");
                verificar = int.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, opção invalida.");
            }
            switch (userout)
            {
                case 1:
                    CalcPitagoras.Principal();
                    break;
                case 2:
                    CalcEsfera.Principal();
                    break;
                case 3:
                    AreaCirc.Principal();
                    break;
                case 4:
                    break;
            }
        }
        public static void Fim()
        {
            Console.WriteLine("Obrigado por utilizar o meu Software, Artur6768, 2022");
            Console.WriteLine("Retornado ao Terminal...");
            Environment.ExitCode = -1;
        }
        public static void Escolha()
        {
            //VARIAVEL LOCAL
            bool miniverificar = true;
            //
            while (miniverificar)
            {
                Console.WriteLine("Pressione enter para continuar.");
                _ = Console.ReadLine();
                Console.WriteLine("Deseja usar outra calculadora? (S/n)");
                string retornar = Console.ReadLine();
                switch (retornar)
                {
                    case "y" or "Y" or "S" or "s":
                        miniverificar = false;
                        UserInterface.Selecao();
                        break;
                    case "n" or "N":
                        miniverificar = false;
                        UserInterface.Fim();
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("Erro, opção invalida, use S para sim e N para não.");
            }
        }
    }
    class CalcPitagoras
    {
        public static void Principal()
        {
            //VARS LOCAL
            bool verificar;
            double cat1;
            double cat2;
            double catqua1;
            double catqua2;
            double resultado;
            //
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do primeiro cateto.");
                verificar = double.TryParse(Console.ReadLine(), out (cat1));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do segundo cateto.");
                verificar = double.TryParse(Console.ReadLine(), out (cat2));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            catqua1 = (cat1 * cat1);
            catqua2 = (cat2 * cat2);
            resultado = Math.Sqrt(catqua1 + catqua2);
            Console.WriteLine($"O resultado da hipotenusa é: {resultado}");
            UserInterface.Escolha();
        }
    }
    class CalcEsfera
    {
        //RECEBER GLOBAL
        readonly double pi = VariaveisGlobais.Pi;
        //
        //VARS CLASSE
        bool verificar;
        double userout;
        double volume;
        //
        public static void Principal()
        {
            //VARS LOCAL
            bool verificar;
            int userout;
            //
            Console.WriteLine("==========================================\n" +
                                        "O que deseja fazer ?\n" +
                                        "[1] Usar diâmetro\n" +
                                        "[2]  Usar raio\n" +
                                        "[3]   Voltar \n" +
                              "==========================================");
            while (true)
            {
                Console.Write("Sua escolha: ");
                verificar = int.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, opção invalida.");
            }
            verificar = false;
            switch (userout)
            {
                case 1:
                    var instanciadiametro = new CalcEsfera();
                    instanciadiametro.Diametro();
                    break;
                case 2:
                    var instanciaraio = new CalcEsfera();
                    instanciaraio.Raio();
                    break;
                case 3:
                    UserInterface.Selecao();
                    break;
            }
        }
        public void Diametro()
        {
            //VARS LOCAL
            double dira;
            double ra;
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do diametro em centímetros: ");
                verificar = double.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            dira = (userout / 2);
            ra = (dira * dira * dira);
            volume = (4*pi*ra)/3;
            Console.WriteLine($"O volume desta esfera é {volume} m3");
            UserInterface.Escolha();
        }
        public void Raio()
        {

        }
    }
    class AreaCirc
    {
        //RECEBER GLOBAL
        readonly double pi = VariaveisGlobais.Pi;
        //
        //VARIAVEIS DA CLASSE
        double resultado;
        bool verificar;
        double userout;
        //
        public static void Principal()
        {
            //VARS LOCAL
            bool verificar;
            int userout;
            //
            Console.WriteLine("==========================================\n" +
                                        "O que deseja fazer ?\n" +
                                        "[1] Usar diâmetro\n" +
                                        "[2]  Usar raio\n" +
                                        "[3]   Voltar \n" +
                              "==========================================");
            while (true)
            {
                Console.Write("Sua escolha: ");
                verificar = int.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, opção invalida.");
            }
            verificar = false;
            switch (userout)
            {
                case 1:
                    var instanciadiametro = new AreaCirc();
                    instanciadiametro.Diametro();
                    break;
                case 2:
                    var instanciaraio = new AreaCirc();
                    instanciaraio.Raio();
                    break;
                case 3:
                    UserInterface.Selecao();
                    break;
            }
        }
        public void Diametro()
        {
            //VARS LOCAL
            double ra1;
            double ra2;
            //
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do diametro em centímetros: ");
                verificar = double.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            ra1 = (userout / 2);
            ra2 = (ra1 * ra1);
            resultado = (pi * ra2);
            Console.WriteLine($"A área deste circulo é {resultado} M²");
            UserInterface.Escolha();
        }
        public void Raio()
        {
            //VARS LOCAL
            //
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do raio em centímetros: ");
                verificar = double.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            resultado = (pi) * (userout * userout);
            Console.WriteLine($"A área deste circulo é {resultado} CM²");
            UserInterface.Escolha();
        }
    }
    class CumprCirc
    {

    }
}
