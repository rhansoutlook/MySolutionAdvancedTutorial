;#DropDB MySolutionAdvancedTutorialEasyTest

#Application MySolutionAdvancedTutorial.Win
#Application MySolutionAdvancedTutorial.Web
#IfDef MySolutionAdvancedTutorial.Win

*Action About...
 
*Action OK

#EndIf

#IfDef MySolutionAdvancedTutorial.Web
*Action Navigation(My Details)
#EndIf
