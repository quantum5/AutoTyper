@move bin\Release\AutoTyper.exe bin\Release\AutoTyper2.exe
@del bin\Release\AutoTyper.pdb
@ILMerge.exe /t:winexe /out:bin\Release\AutoTyper.exe bin\Release\AutoTyper2.exe ICSharpCode.TextEditor.dll LinqBridge.dll