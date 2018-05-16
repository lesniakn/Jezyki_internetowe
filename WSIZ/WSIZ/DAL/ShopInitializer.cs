using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WSIZ.Models;

namespace WSIZ.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var przedmiot = new List<Przedmiot>
            {
        new Przedmiot()
        {
            NazwaPrzedmiotu = "ASUS H110M-K", ProducentPrzedmiotu = "Asus", KategoriaID = 1, CenaPrzedmiotu = 209,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Standard płyty: micro-ATX. Gniazdo procesora: Socket 1151. Chipset płyty głównej: Intel H110"},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "MSI Z370-A PRO", ProducentPrzedmiotu = "MSI", KategoriaID = 1, CenaPrzedmiotu = 469,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Standard płyty: ATX. Gniazdo procesora: Socket 1151. Chipset płyty głównej: Intel Z370"},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Gigabyte X299 DESIGNARE EX", ProducentPrzedmiotu = "MSI", KategoriaID = 1, CenaPrzedmiotu = 2149,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Standard płyty: ATX. Gniazdo procesora: Socket 2066. Chipset płyty głównej: Intel X299"},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "NVIDIA GeForce GTX 1050 2GB", ProducentPrzedmiotu = "MSI", KategoriaID = 2, CenaPrzedmiotu = 788,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Typ złącza: PCI-Express x16, Szyna danych pamięci: 128bit, Typ zastosowanej pamięci: GDDR5 2048 MB"},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Sapphire Radeon RX 580 4G NITRO+", ProducentPrzedmiotu = "Asus", KategoriaID = 2, CenaPrzedmiotu = 1512,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Typ złącza: PCI-Express x16, Szyna danych pamięci: 256bit, Typ zastosowanej pamięci: GDDR5 4096 MB"},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Creative Sound Blaster ZxR", ProducentPrzedmiotu = "Creative", KategoriaID = 3, CenaPrzedmiotu = 641,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Sztandarowa, wysokiej wydajności karta dźwiękowa PCIe. Najwyzsza jakosc dzwieku podczas sluchania i tworzenia muzyki dzieki technologii Sound Blaster i komponentom o jakosci studyjnej."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Asus Strix Soar", ProducentPrzedmiotu = "Asus", KategoriaID = 3, CenaPrzedmiotu = 319,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Strix Soar to karta dźwiękowa dla graczy wyposażona w podzespoły o wysokiej wydajności, która spełni wymogi najbardziej wymagających graczy, oczekujących czystego, pełnego dźwięku. Strix Soar dostarcza bogaty, głęboki i czysty dźwięk o współczynniku sygnału do szumu na poziomie 116dB, a wzmacniacz słuchawkowy 600 omów zapewnia mocny bas. Proste, ale potężne narzędzie Sonic Studio umożliwia pełną kontrolę karty dźwiękowej i ustawień dźwięku w grze."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Creative SB Audigy RX", ProducentPrzedmiotu = "Creative", KategoriaID = 3, CenaPrzedmiotu = 249,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Sound Blaster Audigy Rx to zaawansowana karta dzwiekowa, która stanowi idealne rozszerzenie podstawowego ukladu dzwiekowego na plycie glównej w celu zapewnienia wciagajacego dzwieku przestrzennego o jakosci kinowej. Zaawansowany uklad zaprojektowany na potrzeby przetwarzania przez nasz legendarny mechanizm poglosu EAX sprawia, ze uzytkownicy karty Sound Blaster Audigy Rx moga spodziewac sie doskonalego dzwieku wielokanalowego 7.1."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "WD Red 4TB", ProducentPrzedmiotu = "WD", KategoriaID = 4, CenaPrzedmiotu = 569,
                DataDodania = DateTime.Now, OpisPrzedmiotu = ""},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Seagate IronWolf 2TB", ProducentPrzedmiotu = "Seagate", KategoriaID = 4, CenaPrzedmiotu = 309,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Dysk IronWolf idealnie sprawdza się we wszelkich zastosowaniach związanych z pamięcią NAS. Stale uruchomiony dysk IronWolf został ulepszony o technologię AgileArray™ zapewniającą optymalną niezawodność i sprawność systemu. Technologia Multi-user oraz ekstremalnie wysokie wskaźniki obciążenia pracą pozwalają dyskom IronWolf utrzymywać jakość i rozwijać się wraz z przedsiębiorstwem."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Logitech M185 Niebieska", ProducentPrzedmiotu = "Logitech", KategoriaID = 5, CenaPrzedmiotu = 69,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Logitech M185 to mysz bezprzewodowa o wyprofilowanym kształcie. Została wyposażona w niewielki bezprzewodowy odbiornik, który dzięki swym rozmiarom może być stale podłączony do komputera. Stabilna łączność bezprzewodowa zapewnia transmisję danych bez zakłóceń. Może działać nawet do 12 miesięcy bez konieczności wymiany baterii."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Asus Cerberus Czarna", ProducentPrzedmiotu = "Asus", KategoriaID = 5, CenaPrzedmiotu = 99,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "ASUS Cerberus Optical Gaming Mouse to myszka, która jest odpowiedzią na potrzeby nawet tych bardziej wymagających graczy. Jej sercem jest sensor optyczny, który charakteryzuje się bardzo wysoką czułością i pracuje w rozdzielczości od 500 do nawet 2500 DPI. Jest to bardzo istotne w wielu różnych gatunkach gier wideo – od pierwszoosobowych strzelanek, przez zręcznościówki, aż po dynamiczne strategie czasu rzeczywistego. Gryzoń przykuwa uwagę nie tylko tym co wewnątrz, ale też wyglądem."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Logitech MX Master 2S", ProducentPrzedmiotu = "Logitech", KategoriaID = 5, CenaPrzedmiotu = 368,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "MX Master 2S to nowa mysz flagowa Logitech®, którą cechuje wygodny, ręcznie wyrzeźbiony kształt, oszałamiający styl, zasilanie akumulatorem oraz zaawansowane funkcje, które przenoszą obsługę wielu komputerów na zupełnie nowy poziom dzięki technologii FLOW."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Razer Blackwidow Chroma V2", ProducentPrzedmiotu = "Razer", KategoriaID = 5, CenaPrzedmiotu = 599,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Mechaniczna klawiatura do gier Razer BlackWidow miała swoją premierę w 2010 r. i szybko stała się najpopularniejszą i najlepiej sprzedającą się klawiaturą do gier na świecie oraz ulubieńcem zawodowych graczy. Cztery lata później przedstawiliśmy Razer™ Mechanical Switch, które sprawiły Razer BlackWidow jeszcze lepszą dzięki pierwszym na świecie mechanicznym przełącznikom klawiszy stworzonym specjalnie z myślą o graczach."},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Logitech K270", ProducentPrzedmiotu = "Logitech", KategoriaID = 5, CenaPrzedmiotu = 119,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Logitech K270"},
                new Przedmiot()
        {
            NazwaPrzedmiotu = "Logic LK-12 czarna", ProducentPrzedmiotu = "Logic", KategoriaID = 5, CenaPrzedmiotu = 19,
                DataDodania = DateTime.Now, OpisPrzedmiotu = "Logic LK-12 to niezwykle wygodna i ergonomiczna klawiatura, którą cechuje prostota oraz funkcjonalność. Standardowy układ klawiszy z pełnym blokiem numerycznym umożliwia wygodne i łatwe korzystanie z klawiatury. "},

            };
            przedmiot.ForEach(s => context.Przedmiot.Add(s));
            context.SaveChanges();

            var kategoria = new List<Kategoria>
            {

                new Kategoria {KategoriaID=1, NazwaKategorii = "Płyty główne", OpisKategorii="Płyta główna to jeden z pierwszych elementów, który montujemy w obudowie, podczas składania komputera PC. Do płyt głównych podłączane są wszystkie inne podzespoły i to one w dużej mierze determinuje możliwość późniejszego rozbudowania naszego zestawu. Z tego względu warto dobrze przemyśleć zakup konkretnego modelu – zdecydowanie lepiej skupić się na rozwiązaniach przyszłościowych. Jak wybrać płytę główną do komputera lub płytę główną do gier? Główna linia podziału biegnie między płytami głównymi kompatybilnymi z procesorami Intel lub dedykowanymi procesorom AMD."},
                new Kategoria {KategoriaID=2, NazwaKategorii = "Karty graficzne", OpisKategorii="Karty graficzne odpowiadają za generowanie obrazu, który następnie może być wyświetlany na ekranie monitora lub telewizora. Właściwości obrazu zależą od zastosowanej karty graficznej oraz w mniejszym stopniu od pozostałych podzespołów komputera. Zaawansowane oprogramowanie graficzne oraz najnowsze gry będą wymagały zastosowania bardzo wydajnych układów."},
                new Kategoria {KategoriaID=3, NazwaKategorii = "Karty dźwiękowe", OpisKategorii="Karty dźwiękowe to części PC, które odpowiadają za obsługę funkcji audio. Podzespoły określane też jako karty muzyczne czuwają nad odtwarzaniem i nagrywaniem dźwięku w komputerze. Choć płyty główne mają zintegrowane karty dźwiękowe, taka dodatkowa pozwala osiągnąć wyższą jakość audio i zapewnia zgodność z nowoczesnymi standardami."},
                new Kategoria {KategoriaID=4, NazwaKategorii = "Dyski", OpisKategorii="Dyski zapewniają powierzchnię do przechowywania oprogramowania systemowego, dokumentów, multimediów i innych danych. Dzielimy je ze względu na typ nośnika, format nośnika oraz jego przeznaczenie. Modele należące do poszczególnych grup różnią się dodatkowo pojemnością."},
                new Kategoria {KategoriaID=5, NazwaKategorii = "Myszki", OpisKategorii="Urządzenie wskazujące używane podczas pracy z interfejsem graficznym systemu komputerowego."},
                new Kategoria {KategoriaID=6, NazwaKategorii = "Klawiatury", OpisKategorii="Uporządkowany zestaw klawiszy służący do ręcznego sterowania urządzeniem lub ręcznego wprowadzania danych."}

            };
            kategoria.ForEach(k => context.Kategoria.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}