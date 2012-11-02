FILE=ASCIItoKey.cs \
     Controller.Designer.cs \
     Controller.cs \
     FocusControl.cs \
     KeyParser.cs \
     Program.cs \
     SendInput.cs \
     SyntaxError.cs \
     Properties\AssemblyInfo.cs \
     Properties\Resources.Designer.cs \
     Properties\Settings.Designer.cs \
     Typer\KeyBDEventTyper.cs \
     Typer\SendInputTyper.cs \
     Typer\Typer.cs \
     TypingItems\ControlItem.cs \
     TypingItems\KeyComboItem.cs \
     TypingItems\StringItem.cs \
     TypingItems\TypeItem.cs
CSC=csc.exe
CSFLAGS=

all: AutoTyper.exe

AutoTyper.exe: $(FILE)
	$(CSC) $(CSFLAGS) /t:winexe /out:$@ $(FILE)
