# Makefile.in generated automatically by automake 1.4-p6 from Makefile.am

# Copyright (C) 1994, 1995-8, 1999, 2001 Free Software Foundation, Inc.
# This Makefile.in is free software; the Free Software Foundation
# gives unlimited permission to copy and/or distribute it,
# with or without modifications, as long as this notice is preserved.

# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY, to the extent permitted by law; without
# even the implied warranty of MERCHANTABILITY or FITNESS FOR A
# PARTICULAR PURPOSE.


SHELL = /bin/sh

srcdir = .
top_srcdir = ../..

prefix = /usr/local
exec_prefix = ${prefix}

bindir = ${exec_prefix}/bin
sbindir = ${exec_prefix}/sbin
libexecdir = ${exec_prefix}/libexec
datadir = ${prefix}/share
sysconfdir = ${prefix}/etc
sharedstatedir = ${prefix}/com
localstatedir = ${prefix}/var
libdir = ${exec_prefix}/lib
infodir = ${prefix}/info
mandir = ${prefix}/man
includedir = ${prefix}/include
oldincludedir = /usr/include

DESTDIR =

pkgdatadir = $(datadir)/uiplinux
pkglibdir = $(libdir)/uiplinux
pkgincludedir = $(includedir)/uiplinux

top_builddir = ../..

ACLOCAL = aclocal-1.4
AUTOCONF = autoconf
AUTOMAKE = automake-1.4
AUTOHEADER = autoheader

INSTALL = /usr/bin/install -c
INSTALL_PROGRAM = ${INSTALL} $(AM_INSTALL_PROGRAM_FLAGS)
INSTALL_DATA = ${INSTALL} -m 644
INSTALL_SCRIPT = ${INSTALL}
transform = s,x,x,

NORMAL_INSTALL = :
PRE_INSTALL = :
POST_INSTALL = :
NORMAL_UNINSTALL = :
PRE_UNINSTALL = :
POST_UNINSTALL = :
build_alias = 
build_triplet = i686-pc-linux-gnu
host_alias = 
host_triplet = i686-pc-linux-gnu
target_alias = 
target_triplet = i686-pc-linux-gnu
CC = @CC@
CSC = no
HAVE_LIB = @HAVE_LIB@
LIB = @LIB@
LTLIB = @LTLIB@
MAINT = #
MAKEINFO = makeinfo
MCS = /usr/bin/mcs
PACKAGE = uiplinux
PKG_CONFIG = /usr/bin/pkg-config
VERSION = 1.0.0.0

cocktailzilladir = $(bindir)
cocktailzilla_SCRIPTS = CocktailZilla.exe
EXTRA_DIST = $(cocktailzilla_sources) $(cocktailzilla_sources_in)
CLEANFILES = CocktailZilla.exe

cocktailzilla_sources_in = AssemblyInfo.cs.in
cocktailzilla_generated_sources = $(cocktailzilla_sources_in:.in=)
cocktailzilla_sources = Debug/Main.cs Model/DBCon.cs 

CSHARP_LIBS = -r:System.Data -r:System.Windows.Forms -r:System.Web -r:System.Drawing -r:../dll.GotDotNet.daab.3/GotDotNet.ApplicationBlocks.Data.dll -r:glib-sharp -r:gtk-sharp -r:gdk-sharp -lib:/usr/lib/mono/gtk-sharp/
cocktailzilla_build_sources = $(addprefix $(srcdir)/, $(cocktailzilla_sources)) $(cocktailzilla_generated_sources)
mkinstalldirs = $(SHELL) $(top_srcdir)/mkinstalldirs
CONFIG_CLEAN_FILES =  AssemblyInfo.cs
SCRIPTS =  $(cocktailzilla_SCRIPTS)

DIST_COMMON =  AssemblyInfo.cs.in Makefile.am Makefile.in


DISTFILES = $(DIST_COMMON) $(SOURCES) $(HEADERS) $(TEXINFOS) $(EXTRA_DIST)

TAR = tar
GZIP_ENV = --best
all: all-redirect
.SUFFIXES:
$(srcdir)/Makefile.in: # Makefile.am $(top_srcdir)/configure.in $(ACLOCAL_M4) 
	cd $(top_srcdir) && $(AUTOMAKE) --gnu src/CocktailZilla/Makefile

Makefile: $(srcdir)/Makefile.in  $(top_builddir)/config.status $(BUILT_SOURCES)
	cd $(top_builddir) \
	  && CONFIG_FILES=$(subdir)/$@ CONFIG_HEADERS= $(SHELL) ./config.status

AssemblyInfo.cs: $(top_builddir)/config.status AssemblyInfo.cs.in
	cd $(top_builddir) && CONFIG_FILES=$(subdir)/$@ CONFIG_HEADERS= $(SHELL) ./config.status

install-cocktailzillaSCRIPTS: $(cocktailzilla_SCRIPTS)
	@$(NORMAL_INSTALL)
	$(mkinstalldirs) $(DESTDIR)$(cocktailzilladir)
	@list='$(cocktailzilla_SCRIPTS)'; for p in $$list; do \
	  if test -f $$p; then \
	    echo " $(INSTALL_SCRIPT) $$p $(DESTDIR)$(cocktailzilladir)/`echo $$p|sed '$(transform)'`"; \
	    $(INSTALL_SCRIPT) $$p $(DESTDIR)$(cocktailzilladir)/`echo $$p|sed '$(transform)'`; \
	  else if test -f $(srcdir)/$$p; then \
	    echo " $(INSTALL_SCRIPT) $(srcdir)/$$p $(DESTDIR)$(cocktailzilladir)/`echo $$p|sed '$(transform)'`"; \
	    $(INSTALL_SCRIPT) $(srcdir)/$$p $(DESTDIR)$(cocktailzilladir)/`echo $$p|sed '$(transform)'`; \
	  else :; fi; fi; \
	done

uninstall-cocktailzillaSCRIPTS:
	@$(NORMAL_UNINSTALL)
	list='$(cocktailzilla_SCRIPTS)'; for p in $$list; do \
	  rm -f $(DESTDIR)$(cocktailzilladir)/`echo $$p|sed '$(transform)'`; \
	done
tags: TAGS
TAGS:


distdir = $(top_builddir)/$(PACKAGE)-$(VERSION)/$(subdir)

subdir = src/CocktailZilla

distdir: $(DISTFILES)
	here=`cd $(top_builddir) && pwd`; \
	top_distdir=`cd $(top_distdir) && pwd`; \
	distdir=`cd $(distdir) && pwd`; \
	cd $(top_srcdir) \
	  && $(AUTOMAKE) --include-deps --build-dir=$$here --srcdir-name=$(top_srcdir) --output-dir=$$top_distdir --gnu src/CocktailZilla/Makefile
	$(mkinstalldirs) $(distdir)/Debug $(distdir)/Model
	@for file in $(DISTFILES); do \
	  d=$(srcdir); \
	  if test -d $$d/$$file; then \
	    cp -pr $$d/$$file $(distdir)/$$file; \
	  else \
	    test -f $(distdir)/$$file \
	    || ln $$d/$$file $(distdir)/$$file 2> /dev/null \
	    || cp -p $$d/$$file $(distdir)/$$file || :; \
	  fi; \
	done
info-am:
info: info-am
dvi-am:
dvi: dvi-am
check-am: all-am
check: check-am
installcheck-am:
installcheck: installcheck-am
install-exec-am:
install-exec: install-exec-am

install-data-am: install-cocktailzillaSCRIPTS
install-data: install-data-am

install-am: all-am
	@$(MAKE) $(AM_MAKEFLAGS) install-exec-am install-data-am
install: install-am
uninstall-am: uninstall-cocktailzillaSCRIPTS
uninstall: uninstall-am
all-am: Makefile $(SCRIPTS)
all-redirect: all-am
install-strip:
	$(MAKE) $(AM_MAKEFLAGS) AM_INSTALL_PROGRAM_FLAGS=-s install
installdirs:
	$(mkinstalldirs)  $(DESTDIR)$(cocktailzilladir)


mostlyclean-generic:

clean-generic:
	-test -z "$(CLEANFILES)" || rm -f $(CLEANFILES)

distclean-generic:
	-rm -f Makefile $(CONFIG_CLEAN_FILES)
	-rm -f config.cache config.log stamp-h stamp-h[0-9]*

maintainer-clean-generic:
mostlyclean-am:  mostlyclean-generic

mostlyclean: mostlyclean-am

clean-am:  clean-generic mostlyclean-am

clean: clean-am

distclean-am:  distclean-generic clean-am

distclean: distclean-am

maintainer-clean-am:  maintainer-clean-generic distclean-am
	@echo "This command is intended for maintainers to use;"
	@echo "it deletes files that may require special tools to rebuild."

maintainer-clean: maintainer-clean-am

.PHONY: uninstall-cocktailzillaSCRIPTS install-cocktailzillaSCRIPTS tags \
distdir info-am info dvi-am dvi check check-am installcheck-am \
installcheck install-exec-am install-exec install-data-am install-data \
install-am install uninstall-am uninstall all-redirect all-am all \
installdirs mostlyclean-generic distclean-generic clean-generic \
maintainer-clean-generic clean mostlyclean distclean maintainer-clean


CocktailZilla.exe: cpdll $(cocktailzilla_build_sources)
	$(MCS) $(GTKSHARP_LIBS) $(embedded) $(CSHARP_LIBS) -g -out:$@ $(cocktailzilla_build_sources)
cpdll:
	cp ../dll.GotDotNet.daab.3/GotDotNet.ApplicationBlocks.Data.dll $(srcdir)

# Tell versions [3.59,3.63) of GNU make to not export all variables.
# Otherwise a system limit (for SysV at least) may be exceeded.
.NOEXPORT:
