![App Splashart](https://i.imgur.com/T9h5izP.png)

# Innovationen mit AR - Erlebniswelt Meeresbiologie
<b>Unterwasserwelten im Deutschen Museum erforschen mit innovativen AR Erlebnissen.</b><br>
Ein Video zur Anwendung steht bereit unter der folgenden Adresse: https://bit.ly/ar-dmu-dexperio

## Inhalt
1. [Projektüberblick](#toc1)
2. [Teilprojekte](#toc2) <br>
2.1  [Abtauchen mit JAGO](#toc21) <br>
2.1  [JAGO erkunden](#toc22) <br>
2.1  [Die Meereswelt begreifen](#toc23) <br> 
2.1  [Gehe auf Beutefang](#toc24) <br>
3. [Projekt](#toc3)
4. [Lizenzierung](#toc4)
5. [Hinweise](#toc5)

## 1. Projektüberblick <a name="toc1"></a>
<b>Diese AR-Anwendung ist entstanden im Verbundprojekt museum4punkt0 – Digitale Strategien für das Museum der Zukunft, Teilprojekt "3D-Digitalisierung und –Visualisierung".</b> Weitere Informationen: www.museum4punkt0.de.</b>

Das Projekt museum4punkt0 wird gefördert durch die Beauftragte der Bundesregierung für Kultur und Medien aufgrund eines Beschlusses des Deutschen Bundestages.

Die AR Erlebniswelt wurde für eine Austellungsinsel im Deutschen Museum im Bereich der Meeresbiologie-Ausstellung konzipiert, bei der das Tauchbot JAGO im Vordergrund steht. Die Anwendung ist für die Verwendung im Museum gedacht, ist aber auch außerhalb des Museumskontextes erlebbar. Weitere Hinweise hierzu finden sich in der Anwendung.  

Das Projekt verfolgt das Ziel, verschiedene AR Erlebnisformen in einem Anwendungskontext erlebbar zu machen. Details zu den einzelnen Teilanwendungen finden sich untenstehend.

Vielen Dank an dieser Stelle zur Bereitstellung des JAGO 3D Modells durch das GEOMAR Helmholtz-Zentrum für Ozeanforschung Kiel.
https://www.geomar.de/zentrum/einrichtungen/tlz/jago/uebersicht/

## 2. Teilprojekte <a name="toc2"></a>
<b>Die Gesamtanwendung wurde für die Veröffentlichung in diesem Repository in vier Teilprojekte zerlegt.</b><br>

Anmerkung zu technischen Hinweisen: Die <b>technischen Hinweise</b> zur jeweiligen Anwendung mit Angaben zu benötigter Hard- und Software finden sich in eigenen Readme-Dateien in den entsprechenden Projektverzeichnissen. Diese sind untenstehend in den jeweiligen Abschnitten verlinkt.

### 2.1 Abtauchen mit JAGO <a name="toc21"></a>
![Abtauchen mit Jago](https://i.imgur.com/1jbNsHi.png)

<b>AR-Erlebnistyp "Erweiterte Visualisierung/Präsentation" -> AR-Stage Experience</b></br>
Ran an's Steuer - Hier lernst Du mit der JAGO Ab- und Aufzutauchen.

<b>SZENARIO:</b> In diesem Teil der Anwendung erhalten die Besucher eine 3D Präsentation des
Unterwasserfahrzeuges JAGO auf der Ausstellungsfläche, zusammen mit wissenswerten Fakten in Form
einer interaktiven und multimedialen Präsentation.

<b>INTERAKTION:</b> Die Besucher haben über ein bereitgestelltes Tablet die Möglichkeit, das
Unterwasserboot JAGO in der Mitte der Ausstellungsfläche zu platzieren und sich über verschiedene 3D
Ansichten zusammen mit multimedialen Visualisierungslementen (Bildern, Video, Text) zu informieren.
Informationen wählt er über Hotspots am 3D Objekt aus oder über Navigationsbuttons auf dem Tablet.

<b>MEHRWERTE:</b> Die Besucher können das derzeit gar nicht als reales Objekt ausgestellte Exponat auf einer
virtuellen AR Bühne erkunden, die inmitten des Exponates entsteht. Neben verschiedenen
Visualisierungsmöglichkeiten von JAGO in 3D und der Erklärung des Objektes selbst entsteht für das
Museum die Möglichkeit, das Exponat um eine Vielzahl von Zusatzinformationen und
Visualisierungsformen zu bereichern. Im Rahmen des museum4punkt0 Projektes können außerdem
verschiedene Optionen zur Generierung von 3D Daten verglichen werden: von photogrammetrischen
Verfahren basierend auf einem Miniaturmodell, über die manuelle Nachmodellierung bis hin zur
Optimierung/Konvertierung von ursprünglichen 3D Konstruktionsdaten. Siehe hierzu unten den Punkt Anmerkungen.

<b>TECHNIK:</b> Das AR Tracking für die Erkennung der Präsentationsfläche im Exponat kann über Marker-
oder Ground-Plane Erkennung realisiert werden. In der umgesetzten Version kommt ein speziell für das Projekt angefertigter Marker (Plakat in der Größe 50 x 70 cm) zum Einsatz. Der Marker als Bild ist hier zu finden: [Download](https://imgur.com/T9h5izP)

Zum Teilprojekt [DMU-DMX-Abtauchen](https://github.com/DEXPERIO/DMU-DMX-Master/tree/master/DMU-DMX-Abtauchen). Dort finden sich technische Hinweise zu den Anforderungen an die Hard- und Software.

### 2.2 JAGO erkunden <a name="toc22"></a>
![Jago erkunden](https://i.imgur.com/gDDnncy.png)

<b>AR-Erlebnistyp: "Exploration im Raum"-> AR Portal Experience</b></br>
Hast Du Lust, das JAGO Tauchboot von innen zu erkunden? Steig einfach ein!

<b>SZENARIO:</b> In diesem Teil der Anwendung erhält der Benutzer die Möglichkeit, den Innenraum der JAGO
anhand des 3D-Modells in annähernder Live-Größe, basierend auf einem 360° Panorama zu erkunden.

<b>INTERAKTION:</b> Der Besucher platziert zunächst das 3D-Modell der JAGO im Raum an einer geeigneten
Stelle. Anschließend kann er den Innenraum der JAGO über das "Betreten" durch die Luke der JAGO
erkunden.

<b>MEHRWERTE:</b> Der Besucher hat über diesen AR-Portal Ansatz die Gelegenheit, den Innenraum eines
Ausstellungsobjektes zu erkunden, was ohne die reale Bereitstellung des entsprechenden Objektes - hier
der JAGO - in Lebensgröße sonst nicht möglich wäre. Grundsätzlich erhält das Museum über den Einsatz
von AR-Portalen die Möglichkeit, den vorhandenen Raum im Museum virtuell zu erweitern und
explorative Ausstellungerlebnisse für eine Vielzahl von virtuellen Exponaten anzubieten, die in der realen
Ausstellungsfläche entweder keinen Platz hätten bzw. bzgl. der Verfügbarkeit der Objekte evtl. gar nicht
real verfügbar wären.

<b>TECHNIK:</b> Das AR-Portal basiert auf dem Zusammenspiel eines 3D-Modells und einer 360°
Innenraum-Aufnahme. Betritt der Benutzer den Innenraum - dies wird durch einen Proximity-Trigger und
die Bewegung des Benutzers im Raum gesteuert - wechselt die Anzeigeperspektive von dem AR-Modus
(Kamera + 3D Modell) in die Panoramaanzeige der 360° Innenraum-Aufnahme. Die Bewegung des Tablets
wird über die Gyro-Sensoren getrackt und dadurch die Position des Tablets und damit der Betrachtung im
Innenraum-Panorama geändert. Beim Benutzer entsteht so der Eindruck, dass der sich tatsächlich im
inneren des Tauchbootes bewegt.

Zum Teilprojekt [DMU-DMX-Erkunden](https://github.com/DEXPERIO/DMU-DMX-Master/tree/master/DMU-DMX-Erkunden). Dort finden sich technische Hinweise zu den Anforderungen an die Hard- und Software.

### 2.3 Die Meereswelt begreifen <a name="toc23"></a>
![Die Meereswelt begreifen](https://i.imgur.com/nlzUP1i.png)

<b>AR-Erlebnistyp "Greifbare Objektexploration" -> AR-Cube Experience</b></br>
Erlebe verschiedene Meeresobjekte hautnah. Greif einfach zu!<br>

<b>SZENARIO:</b> In diesem Teil der Anwendung erhalten die Besucher die Möglichkeit, die hinter Glaszylindern
verborgenen Ausstellungsobjekte mittels AR Technologien im Wortsinne zu "begreifen".

<b>INTERAKTION:</b> Die Besucher verwenden hierzu neben einem Tablet einen AR-Cube der als AR Marker
fungiert und auf den das gewählte Objekt mittels AR projeziert wird. Der Cube hat in etwa die Größe
eines Rubik-Cube Würfels und kann somit gut in der Hand gehalten und bewegt werden. Dadurch ergibt
sich ein "Mixed-Reality" Erlebnis, welches einen intensiven Erlebniseindruck aus der Kombination des
haptischen und visuellen Effekts ermöglicht.

<b>MEHRWERTE:</b> Der Besucher kann die sonst hinter Glas verborgenen Objekte im Wortsinne "begreifen"
und erhält ein intensiveren Erlebniseindruck mit haptischen, visuellen und zusätzlichen informativen
Elementen. Dem Museum werden Möglichkeiten an die Hand gegeben, zusätzliche Fakten und
Erlebnisformate zu bestehenden Exponaten anzubieten und im Rahmen des museum4punkt0
Teilprojektes die Akzeptanz einer neuen 3D Visualisierungsform auszutesten.

<b>TECHNIK:</b> Die Funktionalität basiert auf klassischer AR-Markererkennung, angewandt auf ein
geometrisches Objekt, dem AR Cube. Für die Realisierung kam als Technologie die MERGE Cube Plattform
zum Einsatz (https://mergevr.com/cube?cr=2735), die entsprechende Hard- und Software bereitstellt. Für

Zum Teilprojekt [DMU-DMX-Begreifen](https://github.com/DEXPERIO/DMU-DMX-Master/tree/master/DMU-DMX-Begreifen). Dort finden sich technische Hinweise zu den Anforderungen an die Hard- und Software.

### 2.4 Gehe auf Beutefang <a name="toc24"></a>
![Gehe auf Beutefang](https://i.imgur.com/gK5Kn7b.png)

<b>AR-Erlebnistyp "Gamification im Ausstellungsbereich" -> AR-Arena Experience</b></br>
Gehe auf Beutefang! Sammle Meeresobjekte auf einer Actionfahrt mit der JAGO.

<b>SZENARIO</b>: In diesem Teil der Anwendung wandelt sich der Ausstellungsbereich in eine AR-Game Arena,
die den Besuchern die Möglichkeit gibt, kurz auf Unterwasserjagd mit dem Tauchboot JAGO zu gehen,
und dabei Objekte vom Meeresgrund einzusammeln.

<b>INTERAKTION:</b> Der Besucher hat über ein bereitgestelltes Tablet die Möglichkeit, das Unterwasserboot
JAGO in der Mitte der Ausstellungsfläche zu platzieren und nach dem Spielstart das Boot so zu drehen,
dass er die in unregelmäßigen Abständen aufblinkenden Meeresobjekte über einen Fangstrahl
einsammeln kann. Die im Exponat platzierten Glaszylinder werden hierbei als Zielbereiche verwendet.

<b>MEHRWERTE:</b> Der Besucher hat über diesen Gamification Ansatz die Möglichkeit, vorher erlerntes
Wissen spielerisch "in Action" zu erleben. Das Deutsche Museum kann austesten, wie Gamification Anwendungen mittels AR im Vergleich zu anderen AR Anwendungsformaten ankommen.

<b>TECHNIK:</b> Das AR Tracking für die Erkennung der Präsentationsfläche im Exponat kann über Marker-
oder Ground-Plane Erkennung realisiert werden.

Zum Teilprojekt [DMU-DMX-Beutefang](https://github.com/DEXPERIO/DMU-DMX-Master/tree/master/DMU-DMX-Beutefang). Dort finden sich technische Hinweise zu den Anforderungen an die Hard- und Software.

## 3. Hinweise <a nam3e="toc"></a>
<b>Sourcecode:</b><br> 
Der Sourcecode wurde für den Test der verschiedenen AR-Erlebnisse im Rahmen eines Prototypen entwickelt. Dabei Stand primär im Vordergrund, die gewünschten Funktionen lauffähig abzubilden und nicht den Code hinsichtlich Struktur und Aufbau vergleichbar einer Produduktivanwendung zu optimierenAnmerkung zur Benutzung der Software

<b>Benutzung:</b><br>
Hinweise zur Benutzung der Software sind integraler Bestandteil der Anwendung und werden kontextsensitiv bei der Benutzung der jeweiligen Apps angezeigt.

## 4. Lizenzierung <a name="toc4"></a>
<b>Hinweise zur Lizenzierung der Anwendung und verwendeten Assets</b><br>

<b>JAGO Tauchboot:</b><br>
Die 3D Assets und daraus abgeleiteten 2D Bildformate/Videos des Tauchbootes JAGO werden seitens GEOMAR - Helmholtz Zentrum für Ozeanforschung Kiel im Rahmen der Lizenz Creative Commons CC BY-SA 3.0 bereitgestellt. https://creativecommons.org/licenses/by-sa/3.0/de/

<b>Programmcode:</b></br>
Die vom Auftragnehmer im Rahmen des Projektes erstellten Programmcodes und erstellten/verwendeten Assets werden im Rahmen der MIT License bereitgestellt. Davon ausgenommen sind Elemente, an denen der Auftragnehmer keine Rechte besitzt.

MIT license

Copyright (c) 2020 Deutsches Museum von Meisterwerken der Naturwissenschft und Technik / DEXPERIO GmbH

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## 5. Projekt <a name="toc5"></a>
<b>Diese AR-Anwendung ist entstanden im Verbundprojekt museum4punkt0 – Digitale Strategien für das Museum der Zukunft, Teilprojekt "3D-Digitalisierung und –Visualisierung".</b> Weitere Informationen: www.museum4punkt0.de.</b>

Das Projekt museum4punkt0 wird gefördert durch die Beauftragte der Bundesregierung für Kultur und Medien aufgrund eines Beschlusses des Deutschen Bundestages.

<b>Auftraggeber:</b> des Projektes war das Deutsche Museum von Meisterwerken der Naturwissenschft und Technik (AdöR), Museumsinsel 1, 80538 München.</br> 

<b>Auftragnehmer:</b> DEXPERIO GmbH, Fürstenrieder Str. 201, 81377 München - Konzeption, Design, Entwicklung.<br>
<b>Ansprechpartner:</b> Thomas Fickert, E-Mail: <mailto>hello@dexperio.net<mailto> 
