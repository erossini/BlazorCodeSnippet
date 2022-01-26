# Code Snippet for Blazor
This is a Blazor component to show code in a nice way using [highlight.js](https://highlightjs.org/) [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/).
The component is using [highlight.js](https://highlightjs.org/).

## Usage
In your `Index.html` or `_Host` add this line

```
<script src="/_content/PSC.Blazor.Components.CodeSnippet/codesnippet.js"></script>
```

Then, in your `_Imports.razor` add this line 

```
@using PSC.Blazor.Components.CodeSnippet
```

Based on the parameters, the component adds automatically the required scripts and CSS in your page.

### Add a CodeSnippet
For example, I want to add a C# code with the **Visual Studio* Style. Between the CodeSnippet tag, you have to add the code you want to show. This is the code.

```
<CodeSnippet Language="Language.csharp" Style="Style.VisualStudio">
protected override async Task OnAfterRenderAsync(bool firstRender)
{
    await _js.InvokeVoidAsync("loadJs", targetUrl);
}
</CodeSnippet>
```

Then, I want to add a new CodeSnippet using XML and the style of **Android Studio**. You have to replace special characters like &lt; (&amp;lt;) with the corrispondent HTML code.
If you have multiple `CodeSnippet` in the same pag, you can avoid to load multiple times the `highlight.js` setting to `false` the parameter `LoadMainScript`.

```
<CodeSnippet Language="Language.xml" Style="Style.AndroidStudio" LoadMainScript="false">
&lt;CodeSnippet Language="Language.xml">
&lt;/CodeSnippet>
</CodeSnippet>
```

## Supported languages

| Language | Script |
|----------|--------|
| 1c | 1c.min.js | 
| abnf | abnf.min.js | 
| accesslog | accesslog.min.js | 
| actionscript | actionscript.min.js | 
| ada | ada.min.js | 
| angelscript | angelscript.min.js | 
| apache | apache.min.js | 
| applescript | applescript.min.js | 
| arcade | arcade.min.js | 
| arduino | arduino.min.js | 
| armasm | armasm.min.js | 
| asciidoc | asciidoc.min.js | 
| aspectj | aspectj.min.js | 
| autohotkey | autohotkey.min.js | 
| autoit | autoit.min.js | 
| avrasm | avrasm.min.js | 
| awk | awk.min.js | 
| axapta | axapta.min.js | 
| bash | bash.min.js | 
| basic | basic.min.js | 
| bnf | bnf.min.js | 
| brainfuck | brainfuck.min.js | 
| c | c.min.js | 
| cal | cal.min.js | 
| capnproto | capnproto.min.js | 
| ceylon | ceylon.min.js | 
| clean | clean.min.js | 
| clojure-repl | clojure-repl.min.js | 
| clojure | clojure.min.js | 
| cmake | cmake.min.js | 
| coffeescript | coffeescript.min.js | 
| coq | coq.min.js | 
| cos | cos.min.js | 
| cpp | cpp.min.js | 
| crmsh | crmsh.min.js | 
| crystal | crystal.min.js | 
| csharp | csharp.min.js | 
| csp | csp.min.js | 
| css | css.min.js | 
| d | d.min.js | 
| dart | dart.min.js | 
| delphi | delphi.min.js | 
| diff | diff.min.js | 
| django | django.min.js | 
| dns | dns.min.js | 
| dockerfile | dockerfile.min.js | 
| dos | dos.min.js | 
| dsconfig | dsconfig.min.js | 
| dts | dts.min.js | 
| dust | dust.min.js | 
| ebnf | ebnf.min.js | 
| elixir | elixir.min.js | 
| elm | elm.min.js | 
| erb | erb.min.js | 
| erlang-repl | erlang-repl.min.js | 
| erlang | erlang.min.js | 
| excel | excel.min.js | 
| fix | fix.min.js | 
| flix | flix.min.js | 
| fortran | fortran.min.js | 
| fsharp | fsharp.min.js | 
| gams | gams.min.js | 
| gauss | gauss.min.js | 
| gcode | gcode.min.js | 
| gherkin | gherkin.min.js | 
| glsl | glsl.min.js | 
| gml | gml.min.js | 
| go | go.min.js | 
| golo | golo.min.js | 
| gradle | gradle.min.js | 
| groovy | groovy.min.js | 
| haml | haml.min.js | 
| handlebars | handlebars.min.js | 
| haskell | haskell.min.js | 
| haxe | haxe.min.js | 
| hsp | hsp.min.js | 
| http | http.min.js | 
| hy | hy.min.js | 
| inform7 | inform7.min.js | 
| ini | ini.min.js | 
| irpf90 | irpf90.min.js | 
| isbl | isbl.min.js | 
| java | java.min.js | 
| javascript | javascript.min.js | 
| jboss-cli | jboss-cli.min.js | 
| json | json.min.js | 
| julia-repl | julia-repl.min.js | 
| julia | julia.min.js | 
| kotlin | kotlin.min.js | 
| lasso | lasso.min.js | 
| latex | latex.min.js | 
| ldif | ldif.min.js | 
| leaf | leaf.min.js | 
| less | less.min.js | 
| lisp | lisp.min.js | 
| livecodeserver | livecodeserver.min.js | 
| livescript | livescript.min.js | 
| llvm | llvm.min.js | 
| lsl | lsl.min.js | 
| lua | lua.min.js | 
| makefile | makefile.min.js | 
| markdown | markdown.min.js | 
| mathematica | mathematica.min.js | 
| matlab | matlab.min.js | 
| maxima | maxima.min.js | 
| mel | mel.min.js | 
| mercury | mercury.min.js | 
| mipsasm | mipsasm.min.js | 
| mizar | mizar.min.js | 
| mojolicious | mojolicious.min.js | 
| monkey | monkey.min.js | 
| moonscript | moonscript.min.js | 
| n1ql | n1ql.min.js | 
| nestedtext | nestedtext.min.js | 
| nginx | nginx.min.js | 
| nim | nim.min.js | 
| nix | nix.min.js | 
| node-repl | node-repl.min.js | 
| nsis | nsis.min.js | 
| objectivec | objectivec.min.js | 
| ocaml | ocaml.min.js | 
| openscad | openscad.min.js | 
| oxygene | oxygene.min.js | 
| parser3 | parser3.min.js | 
| perl | perl.min.js | 
| pf | pf.min.js | 
| pgsql | pgsql.min.js | 
| php-template | php-template.min.js | 
| php | php.min.js | 
| plaintext | plaintext.min.js | 
| pony | pony.min.js | 
| powershell | powershell.min.js | 
| processing | processing.min.js | 
| profile | profile.min.js | 
| prolog | prolog.min.js | 
| properties | properties.min.js | 
| protobuf | protobuf.min.js | 
| puppet | puppet.min.js | 
| purebasic | purebasic.min.js | 
| python-repl | python-repl.min.js | 
| python | python.min.js | 
| q | q.min.js | 
| qml | qml.min.js | 
| r | r.min.js | 
| reasonml | reasonml.min.js | 
| rib | rib.min.js | 
| roboconf | roboconf.min.js | 
| routeros | routeros.min.js | 
| rsl | rsl.min.js | 
| ruby | ruby.min.js | 
| ruleslanguage | ruleslanguage.min.js | 
| rust | rust.min.js | 
| sas | sas.min.js | 
| scala | scala.min.js | 
| scheme | scheme.min.js | 
| scilab | scilab.min.js | 
| scss | scss.min.js | 
| shell | shell.min.js | 
| smali | smali.min.js | 
| smalltalk | smalltalk.min.js | 
| sml | sml.min.js | 
| sqf | sqf.min.js | 
| sql | sql.min.js | 
| stan | stan.min.js | 
| stata | stata.min.js | 
| step21 | step21.min.js | 
| stylus | stylus.min.js | 
| subunit | subunit.min.js | 
| swift | swift.min.js | 
| taggerscript | taggerscript.min.js | 
| tap | tap.min.js | 
| tcl | tcl.min.js | 
| thrift | thrift.min.js | 
| tp | tp.min.js | 
| twig | twig.min.js | 
| typescript | typescript.min.js | 
| vala | vala.min.js | 
| vbnet | vbnet.min.js | 
| vbscript-html | vbscript-html.min.js | 
| vbscript | vbscript.min.js | 
| verilog | verilog.min.js | 
| vhdl | vhdl.min.js | 
| vim | vim.min.js | 
| wasm | wasm.min.js | 
| wren | wren.min.js | 
| x86asm | x86asm.min.js | 
| xl | xl.min.js | 
| xml | xml.min.js | 
| xquery | xquery.min.js | 
| yaml | yaml.min.js | 
| zephir | zephir.min.js | 

## Supported style

| Style | CSS file |
|-------|----------|
| a11y-dark | a11y-dark.min.css |
| a11y-light | a11y-light.min.css |
| agate | agate.min.css |
| an-old-hope | an-old-hope.min.css |
| androidstudio | androidstudio.min.css |
| arduino-light | arduino-light.min.css |
| arta | arta.min.css |
| ascetic | ascetic.min.css |
| atom-one-dark-reasonable | atom-one-dark-reasonable.min.css |
| atom-one-dark | atom-one-dark.min.css |
| atom-one-light | atom-one-light.min.css |
| brown-paper | brown-paper.min.css |
| brown-papersq.png | brown-papersq.png |
| codepen-embed | codepen-embed.min.css |
| color-brewer | color-brewer.min.css |
| dark | dark.min.css |
| default | default.min.css |
| devibeans | devibeans.min.css |
| docco | docco.min.css |
| far | far.min.css |
| foundation | foundation.min.css |
| github-dark-dimmed | github-dark-dimmed.min.css |
| github-dark | github-dark.min.css |
| github | github.min.css |
| gml | gml.min.css |
| googlecode | googlecode.min.css |
| gradient-dark | gradient-dark.min.css |
| gradient-light | gradient-light.min.css |
| grayscale | grayscale.min.css |
| hybrid | hybrid.min.css |
| idea | idea.min.css |
| ir-black | ir-black.min.css |
| isbl-editor-dark | isbl-editor-dark.min.css |
| isbl-editor-light | isbl-editor-light.min.css |
| kimbie-dark | kimbie-dark.min.css |
| kimbie-light | kimbie-light.min.css |
| lightfair | lightfair.min.css |
| lioshi | lioshi.min.css |
| magula | magula.min.css |
| mono-blue | mono-blue.min.css |
| monokai-sublime | monokai-sublime.min.css |
| monokai | monokai.min.css |
| night-owl | night-owl.min.css |
| nnfx-dark | nnfx-dark.min.css |
| nnfx-light | nnfx-light.min.css |
| nord | nord.min.css |
| obsidian | obsidian.min.css |
| paraiso-dark | paraiso-dark.min.css |
| paraiso-light | paraiso-light.min.css |
| pojoaque.jpg | pojoaque.jpg |
| pojoaque | pojoaque.min.css |
| purebasic | purebasic.min.css |
| qtcreator-dark | qtcreator-dark.min.css |
| qtcreator-light | qtcreator-light.min.css |
| rainbow | rainbow.min.css |
| routeros | routeros.min.css |
| school-book | school-book.min.css |
| shades-of-purple | shades-of-purple.min.css |
| srcery | srcery.min.css |
| stackoverflow-dark | stackoverflow-dark.min.css |
| stackoverflow-light | stackoverflow-light.min.css |
| sunburst | sunburst.min.css |
| tomorrow-night-blue | tomorrow-night-blue.min.css |
| tomorrow-night-bright | tomorrow-night-bright.min.css |
| vs | vs.min.css |
| vs2015 | vs2015.min.css |
| xcode | xcode.min.css |
| xt256 | xt256.min.css |

## Examples

### CSharp (Visual Studio style)
![CSharp with Code Snippet for Blazor](https://user-images.githubusercontent.com/9497415/151179961-7c4b7477-1ee2-4d71-95c1-5955e6c2ba7d.png)

### Java (Android Studio style)
![Java with Code Snippet for Blazor](https://user-images.githubusercontent.com/9497415/151179370-1ce9fb6f-bd28-4d09-8c7a-dce1e9e91d12.png)

### Swift (XCode style)
![Swift with Code Snippet for Blazor](https://user-images.githubusercontent.com/9497415/151178395-5210843f-2ddd-4e36-86c1-38eb04d1e1b4.png)

---

## Other Blazor components

| Component name | Forum | Description |
|---|---|---|
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) |  This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/add-code-snippet-in-razor-pages/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | Add a button to copy text in the clipbord | 
| SVG Icons and flags for Blazor | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) |  Simple Modal Dialog for Blazor WebAssembly |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) |  A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) |  Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) |  This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) |  This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [WorldMap for Blazor]() | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | Show world maps with your data |

## More examples and documentation
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
