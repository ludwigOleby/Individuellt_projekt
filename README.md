# Individuellt_projekt
Projekt i kursen "Utveckling med C#"

Lägga in grundläggande innehåll i den Readme-fil som finns i ditt Git-repository på Github så att någon som ser projektet för första gången får en kort introduktion till strukturen i koden:

Programet hälsar först användaren välkommen, sedan körs metoden "userLogin()"

I metoden "userLogin()" lagras det fem stycken användare i en 2d-array.
Programmet ber användaren att skriva in sitt användarnamn och lösenord, här har användaren tre försök på sig att skriva in rätt uppgifter annars avslutas programmet.
En while-loop håller koll på att villkoret (rätt användarnamn och lösenord) uppfylls.
När användaren har skrivit in rätt uppgifter körs metoden "userMenu()"

Metoden "userMenu()" visar en meny med 4 olika alternativ:
1. "Se dina konton och saldo" - metod "accountOverview"
2. "Överföring mellan konton" - metod "transfer"
3. "Ta ut pengar" - metod "withdraw"
4. "Logga ut" - användaren skickas tillbaka till metoden "userLogin()"

"userMenu" ligger i ett "switch statement" och skickar användaren till den metod som stämmer överens med deras val.
det finns en integer som heter "currentUser", denna int skickas vidare till den metoden som användaren har valt så att metoden vet vilken användarinformation som skall visas, i samtliga metoder körs en if/if else sats som visar informationen som "currentUser" leder till.


Förklaring til metoderna:

"accountOverview()"
I denna metod så lagras användarens kontouppgifter i två stycken arrayer:

1. "amount" lagrar användarens kontobelopp i en array av datatypen "Double"
2. "accName" lagrar användarens kontonamn i en string-array.

Programmet skriver ut användarens uppgifter i konsollen med hjälp av en for-loop.


"transfer()"
Denna metod utgår ifrån samma arrayer som är lagrade i "accountOverview".
Programmet frågar användaren vilket konto som den vill flytta pengar ifrån (lagras i int "transferAccount")
Sedan vilket konto användaren vill skicka pengarna till (int "recieverAccount")
en while-loop körs för att kontrollera att summan som skall flyttas inte överstiger beloppet på kontot.
sedan körs en if/ if else sats som subtraherar summan från kontot pengarna flyttas ifrån och adderar summan till kontot som pengarna skickas till.
Slutligen körs en For-loop som skriver ut arrayen med det nya saldot.
Användaren skickas sedan tillbaka till "userMenu() metoden"


"withdraw()"
Denna metod utgår från samma arrayer som är lagrade i "accountOverview()"
Programmet frågar användaren vilket konto denne vill ta ut pengar ifrån.
en while-loop körs för att kontrollera så att summan som skall tas ut inte överstiger beloppet på kontot.
En If/if else sats subtraherar summan från kontot som användaren har valt.
Slutligen körs en for-loop som skriver ut arrayen med det nya saldot.
Användaren skickas sedan tillbaka till "userMenu()" metoden.


Skriva en reflektion/ett resonemang där du motiverar för hur du valt att bygga upp ditt program. Du ska alltså resonera kring den lösning du valt, vilka andra du övervägt och kritiskt granska ditt val och eventuellt motivera för bättre lösningar som du ser men inte gjort. Denna motivering ska i din Readme-fil.

Jag har valt att bygga upp mitt program genom att dela in koden i flera olika metoder som körs beroende på vilken användare som är inloggad (integern "currentUser" skickas till de menyval som användaren väljer och sedan körs koden som motsvarar denna integer)
Anledningen till att jag byggde upp koden på detta vis var för att det var det smidigaste sättet jag kom på för att dela upp vilken kod som skall köras baserat på vilken användare som är inloggad.
Då alla användare har tillgång till samma funktioner så kändes detta som en bra lösning.

Detta var dock inte min grundplan, först tänkte jag ha en funktion som heter "accounts()" där de fem användarnas kontouppgifter lagras, dessa uppgifter skulle sedan skickas till den metoden som användaren valde i menyn. Problemet som jag stötte på här och också anledningen till att jag inte gick vidare med denna lösningen var att jag inte lyckades skicka den specifika användarens array till de andra metoderna.
Istället valde jag att lägga in arrayerna direkt i funktionerna, funkionaliteten i programmet blir den samma som den ursprungliga lösningen men jag upprepar mycket kod vilket jag inte hade önskat att göra från början.
Jag fick även dela upp användar-arrayen i två separata arrayer (från början så var den lagrad som en tvådimensionell string-array), detta då jag inte lyckades hitta en funktion som konverterar delar av arrayen till en "double" array så att användaren kan skicka summor bestående av ören.
Jag hade även kunnat komprimera koden i metoden "transfer()" något genom att t.ex skapa en int som håller koll på vilket konto i arrayen användaren väljer att skicka/flytta pengar till. Nu ligger det många if-satser på varandra vilket ser lite rörigt ut.

Jag tror att den snyggaste (och mest effektiva) lösningen på denna uppgiften hade varit att arbeta objektorienterat, man hade då kunnat lagra användarens uppgifter som en klass och sedan kallat på användarens klass i de olika metoderna. Detta har jag dock inte kunskaper för ännu då vi inte har läst om objektorienterad programmering ännu.
