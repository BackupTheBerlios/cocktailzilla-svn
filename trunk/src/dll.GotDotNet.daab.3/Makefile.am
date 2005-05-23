daab3dir=$(bindir)
daab3_SCRIPTS = GotDotNet.ApplicationBlocks.Data.dll
EXTRA_DIST = $(daab3_sources) $(daab3_sources_in)
CLEANFILES = GotDotNet.ApplicationBlocks.Data.dll
#CSHARP_DATALIB="-r:System.Data"
#CSHARP_DAAB="-r:../daab.Microsoft.UIP.1/daab.dll"
#CSHARP_WINDOWS="-r:System.Windows.Forms"
#CSHARP_WEBFORM="-r:System.Web"

CSHARP_LIBS=-r:System.Data -r:ByteFX.Data.dll -r:Mono.Data.SqliteClient.dll
daab3_sources_in = AssemblyInfo.cs.in
daab3_generated_sources = $(daab3_sources_in:.in=)
daab3_sources = ADOHelper.cs DAABSectionHandler.cs SqlServer.cs MySqlServer.cs SqliteServer.cs

daab3_build_sources = $(addprefix $(srcdir)/, $(daab3_sources))
daab3_build_sources += $(daab3_generated_sources)

GotDotNet.ApplicationBlocks.Data.dll: $(daab3_build_sources)
	$(MCS) $(GTKSHARP_LIBS) $(CSHARP_LIBS) -g -target:library -out:$@ $(daab3_build_sources)
#	$(MCS) $(GTKSHARP_LIBS) $(CSHARP_DATALIB) $(CSHARP_WINDOWS) $(CSHARP_WEBFORM) -target:library -out:$@ $(uip_build_sources)

