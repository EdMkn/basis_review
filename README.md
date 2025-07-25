# 📘 basis_review – Révision structurée du C# par modules

Ce projet a pour but d'apprendre et de réviser les bases du langage **C#** de manière **progressive et modulaire**.  
Chaque dossier contient un projet autonome axé sur **un concept précis** du langage, avec des exemples clairs et interactifs.

---

## 🧱 Structure du projet

basis_review/<br/>
├── BasisReview.sln → Solution globale .NET<br/>
├── 01-Variables/ → Déclaration de variables et types<br/>
├── 02-Conditions/ → Structures conditionnelles (if, switch)<br/>
├── 03-Boucles/ → Boucles for, while, do...while, foreach<br/>
├── ... → Modules suivants (04 à 11)<br/>
└── ajouter_module.sh → Script pour créer un nouveau module<br/>


Chaque sous-dossier est un **projet console indépendant**.

---

## 🚀 Utilisation rapide

### Exécuter un module
```bash
dotnet run --project 01-Variables
```

## ✅ Modules disponibles
<table>
<tr><th>Numéro</th>	<th>Thèmes</th>	<th>Description</th> </tr>
<tr><td>01</td>	<td>Variables</td>	<td>Types de base (int, string, etc.)</td> </tr>
<tr><td>02</td>	<td>Conditions</td>	<td>if, else, switch</td></tr>
<tr><td>03</td>	<td>Boucles</td>	<td>for, while, do, foreach</td></tr>
<tr><td>04</td>	<td>Collections</td>	<td>Tableaux, Listes</td></tr>
<tr><td>05</td>	<td>Fonctions</td>	<td>Méthodes, paramètres, retour</td></tr>
<tr><td>06</td>	<td>Classes & Objets</td>	<td>POO, constructeurs, propriétés</td></tr>
<tr><td>07</td>	<td>Héritage & Polymorph.</td>	<td>virtual, override, héritage</td></tr>
<tr><td>08</td>	<td>Exceptions</td>	<td>try, catch, finally</td></tr>
<tr><td>09</td>	<td>Fichiers</td>	<td>Lire/écrire dans un fichier texte</td></tr>
<tr><td>10</td>	<td>LINQ</td>	<td>Requêtes sur des listes</td></tr>
<tr><td>11</td>	<td>Tests unitaires</td>	<td>xUnit, assertions</td></tr>
</table>


