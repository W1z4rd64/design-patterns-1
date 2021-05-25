# Interpreter

## Problem

Das Interpretermuster definiert eine Repr�sentation f�r die Grammatik einer Sprache und die M�glichkeit, S�tze dieser Sprache zu interpretieren.
Z.B. R�mische Zahlen, Datum etc.

## L�sung

Ein Interface 'AbstractExpression' schreibt eine Methode 'Evaluate()' vor, die von allen abgeleiteten, konkreten Klassen implementiert werden muss und die entsprechende Expression auswertet.
F�r den zu interpretierenden Satz wird gem�ss der Grammatik ein Syntaxbaum aus Nichtterminal- und Terminalausdr�cken aufgebaut. Dies kann durch einen externen Parser oder den Client selbst geschehen. 

## Was macht das Pattern

Interpretiert die Anweisungen in einer Sprachgrammatik oder in Notationen.
Dieses Pattern beinhaltet die Implementierung einer Ausdrucksschnittstelle, die angibt, einen bestimmten Kontext zu interpretieren.