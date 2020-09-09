# Connection-ARCore-GVR-Unity
 
Pełny opis projektu znajduje się [TU](https://docs.google.com/document/d/19UhDEN9IDccrzXKvXdUed2qnev0ZcN6ZYM4zv5M7kCs).

## Configuration
Przed zaczęciem projektu należy sprawdzić czy dana wersja Unity wspiera ustawienia AR oraz VR! 
Należy także doinstalować dla danego silnika moduły: Android Build Support wraz z resztą pod dodatków.

Aby zacząć projekt należy - podstawowa konfiguracja:
1. Zmienić docelową platformę. ( File -> Build Settings, zaznaczyć Android i wcisnąć Switch Platform). 
2. W ustawieniach Player Settings (przycisk znajduje się w Build Settings albo można przez Edit -> Project Settings -> Player) trzeba zaznaczyć ARCore Supported oraz Virtual Reality Supported. Oba przyciski są w kategorii XR Settings. Po zaznaczeniu VR Supported trzeba ustawić SDK, w prawym dolnym rogu pojawi się ‘+’ gdzie można dodać Cardboard. Resztę ustawień można zostawić (Dodatek różnicy między multi passem, a single passem).
2. Znajdując się w Player Settings przechodzimy do Other Settings gdzie usuwamy graficzne API Vulcan, zalecają również odznaczenie Multithreading Rendering choć nie potrzeba. Następnie trzeba zmienić nazwę paczki (Unity standardowo krzyczy przy buildowaniu, że nie może zostać domyślną nazwę) oraz zmienić Minimum API Level (Ustawiłem na Lvl 26 dla Androida 8.0).
4. *Przed ostatnim krokiem przygotowania jest zaimportowanie 2 paczek od Googla czyli:
GoogleARCore dla Unity oraz GoogleVR dla Unity. 
5. *Ostatnim krokiem jest ustawienie odpowiednich ścieżek do SDK Androida (o ile Unity automatycznie nie przydzieliło, na screenie używam SDK z nowszej wersji silnika).

#### To do:

* Stworzyć angielską wersję readme (oraz może dokumentu)
* Wyczyścić i ustawić w przejrzysty sposób sceny