FILE=ASCIItoKey.cs Properties\AssemblyInfo.cs Typer\Typer.cs Controller.Designer.cs Properties\Resources.Designer.cs TypingItems\ControlItem.cs Controller.cs Properties\Settings.Designer.cs TypingItems\KeyComboItem.cs KeyParser.cs SyntaxError.cs TypingItems\StringItem.cs Program.cs Typer\KeyBDEventTyper.cs TypingItems\TypeItem.cs
CSC=csc.exe

all: AutoTyper.exe

AutoTyper.exe: $(FILE)
	$(CSC) /t:winexe /out:$@ $(FILE)
