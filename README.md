# repro-obsolete-diagnostics

It seems IDE honors the obsolete ID while the CLI build doesn't:

![](ide.jpg)

![](cli.jpg)

This also causes duplicates in the IDE when building.

Also, the IDE seems to stop honoring the ID as soon as I use an .editorconfig to
alter the severity from warn to error:

![](ide-editorconfig.png)
