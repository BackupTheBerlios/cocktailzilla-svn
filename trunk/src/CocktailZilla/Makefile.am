cocktailzilladir=$(bindir)
cocktailzilla_SCRIPTS = CocktailZilla.exe
EXTRA_DIST = $(cocktailzilla_sources) $(cocktailzilla_sources_in)
CLEANFILES = CocktailZilla.exe

cocktailzilla_sources_in = AssemblyInfo.cs.in
cocktailzilla_generated_sources = $(cocktailzilla_sources_in:.in=)
cocktailzilla_sources = Debug/Main.cs Model/DBCon.cs 

CSHARP_LIBS=-r:System.Data -r:System.Windows.Forms -r:System.Web -r:System.Drawing -r:../dll.GotDotNet.daab.3/GotDotNet.ApplicationBlocks.Data.dll -r:glib-sharp -r:gtk-sharp -r:gdk-sharp -lib:/usr/lib/mono/gtk-sharp/


cocktailzilla_build_sources = $(addprefix $(srcdir)/, $(cocktailzilla_sources))
cocktailzilla_build_sources += $(cocktailzilla_generated_sources)

CocktailZilla.exe: cpdll $(cocktailzilla_build_sources)
	$(MCS) $(GTKSHARP_LIBS) $(embedded) $(CSHARP_LIBS) -g -out:$@ $(cocktailzilla_build_sources)
cpdll:
	cp ../dll.GotDotNet.daab.3/GotDotNet.ApplicationBlocks.Data.dll $(srcdir)
			
	
