using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.CodeSnippet
{
    /// <summary>
    /// Code Style
    /// </summary>
    public enum Style
    {
        /// <summary>
        /// The a11y dark
        /// </summary>
        [Description("a11y-dark")]
        a11y_dark,
        /// <summary>
        /// The a11y light
        /// </summary>
        [Description("a11y-light")]
        a11y_light,
        /// <summary>
        /// The agate
        /// </summary>
        [Description("agate")]
        agate,
        /// <summary>
        /// An old hope
        /// </summary>
        [Description("an-old-hope")]
        an_old_hope,
        /// <summary>
        /// The androidstudio
        /// </summary>
        [Description("androidstudio")]
        AndroidStudio,
        /// <summary>
        /// The arduino light
        /// </summary>
        [Description("arduino-light")]
        ArduinoLight,
        /// <summary>
        /// The arta
        /// </summary>
        [Description("arta")]
        arta,
        /// <summary>
        /// The ascetic
        /// </summary>
        [Description("ascetic")]
        ascetic,
        /// <summary>
        /// The atom one dark reasonable
        /// </summary>
        [Description("atom-one-dark-reasonable")]
        atom_one_dark_reasonable,
        /// <summary>
        /// The atom one dark
        /// </summary>
        [Description("atom-one-dark")]
        atom_one_dark,
        /// <summary>
        /// The atom one light
        /// </summary>
        [Description("atom-one-light")]
        atom_one_light,
        /// <summary>
        /// The brown paper
        /// </summary>
        [Description("brown-paper")]
        brown_paper,
        /// <summary>
        /// The codepen embed
        /// </summary>
        [Description("codepen-embed")]
        CodepenEmbed,
        /// <summary>
        /// The color brewer
        /// </summary>
        [Description("color-brewer")]
        ColorBrewer,
        /// <summary>
        /// The dark
        /// </summary>
        [Description("dark")]
        Dark,
        /// <summary>
        /// The default style
        /// </summary>
        [Description("default")]
        DefaultStyle,
        /// <summary>
        /// The devibeans
        /// </summary>
        [Description("devibeans")]
        devibeans,
        /// <summary>
        /// The docco
        /// </summary>
        [Description("docco")]
        docco,
        /// <summary>
        /// The far
        /// </summary>
        [Description("far")]
        far,
        /// <summary>
        /// The foundation
        /// </summary>
        [Description("foundation")]
        foundation,
        /// <summary>
        /// The github dark dimmed
        /// </summary>
        [Description("github-dark-dimmed")]
        GitHubDarkDimmed,
        /// <summary>
        /// The github dark
        /// </summary>
        [Description("github-dark")]
        GitHubDark,
        /// <summary>
        /// The github
        /// </summary>
        [Description("github")]
        GitHub,
        /// <summary>
        /// The GML
        /// </summary>
        [Description("gml")]
        gml,
        /// <summary>
        /// The googlecode
        /// </summary>
        [Description("googlecode")]
        googlecode,
        /// <summary>
        /// The gradient dark
        /// </summary>
        [Description("gradient-dark")]
        gradient_dark,
        /// <summary>
        /// The gradient light
        /// </summary>
        [Description("gradient-light")]
        gradient_light,
        /// <summary>
        /// The grayscale
        /// </summary>
        [Description("grayscale")]
        GrayScale,
        /// <summary>
        /// The hybrid
        /// </summary>
        [Description("hybrid")]
        Hybrid,
        /// <summary>
        /// The idea
        /// </summary>
        [Description("idea")]
        Idea,
        /// <summary>
        /// The ir black
        /// </summary>
        [Description("ir-black")]
        ir_black,
        /// <summary>
        /// The isbl editor dark
        /// </summary>
        [Description("isbl-editor-dark")]
        isbl_editor_dark,
        /// <summary>
        /// The isbl editor light
        /// </summary>
        [Description("isbl-editor-light")]
        isbl_editor_light,
        /// <summary>
        /// The kimbie dark
        /// </summary>
        [Description("kimbie-dark")]
        kimbie_dark,
        /// <summary>
        /// The kimbie light
        /// </summary>
        [Description("kimbie-light")]
        kimbie_light,
        /// <summary>
        /// The lightfair
        /// </summary>
        [Description("lightfair")]
        lightfair,
        /// <summary>
        /// The lioshi
        /// </summary>
        [Description("lioshi")]
        lioshi,
        /// <summary>
        /// The magula
        /// </summary>
        [Description("magula")]
        magula,
        /// <summary>
        /// The mono blue
        /// </summary>
        [Description("mono-blue")]
        mono_blue,
        /// <summary>
        /// The monokai sublime
        /// </summary>
        [Description("monokai-sublime")]
        monokai_sublime,
        /// <summary>
        /// The monokai
        /// </summary>
        [Description("monokai")]
        monokai,
        /// <summary>
        /// The night owl
        /// </summary>
        [Description("night-owl")]
        night_owl,
        /// <summary>
        /// The NNFX dark
        /// </summary>
        [Description("nnfx-dark")]
        nnfx_dark,
        /// <summary>
        /// The NNFX light
        /// </summary>
        [Description("nnfx-light")]
        nnfx_light,
        /// <summary>
        /// The nord
        /// </summary>
        [Description("nord")]
        nord,
        /// <summary>
        /// The obsidian
        /// </summary>
        [Description("obsidian")]
        obsidian,
        /// <summary>
        /// The paraiso dark
        /// </summary>
        [Description("paraiso-dark")]
        paraiso_dark,
        /// <summary>
        /// The paraiso light
        /// </summary>
        [Description("paraiso-light")]
        paraiso_light,
        /// <summary>
        /// The pojoaque
        /// </summary>
        [Description("pojoaque")]
        pojoaque,
        /// <summary>
        /// The purebasic
        /// </summary>
        [Description("purebasic")]
        PureBasic,
        /// <summary>
        /// The qtcreator dark
        /// </summary>
        [Description("qtcreator-dark")]
        qtcreator_dark,
        /// <summary>
        /// The qtcreator light
        /// </summary>
        [Description("qtcreator-light")]
        qtcreator_light,
        /// <summary>
        /// The rainbow
        /// </summary>
        [Description("rainbow")]
        rainbow,
        /// <summary>
        /// The routeros
        /// </summary>
        [Description("routeros")]
        routeros,
        /// <summary>
        /// The school book
        /// </summary>
        [Description("school-book")]
        school_book,
        /// <summary>
        /// The shades of purple
        /// </summary>
        [Description("shades-of-purple")]
        shades_of_purple,
        /// <summary>
        /// The srcery
        /// </summary>
        [Description("srcery")]
        srcery,
        /// <summary>
        /// The stackoverflow dark
        /// </summary>
        [Description("stackoverflow-dark")]
        StackoverflowDark,
        /// <summary>
        /// The stackoverflow light
        /// </summary>
        [Description("stackoverflow-light")]
        StackoverflowLight,
        /// <summary>
        /// The sunburst
        /// </summary>
        [Description("sunburst")]
        sunburst,
        /// <summary>
        /// The tomorrow night blue
        /// </summary>
        [Description("tomorrow-night-blue")]
        tomorrow_night_blue,
        /// <summary>
        /// The tomorrow night bright
        /// </summary>
        [Description("tomorrow-night-bright")]
        tomorrow_night_bright,
        /// <summary>
        /// The vs
        /// </summary>
        [Description("vs")]
        VisualStudio,
        /// <summary>
        /// The VS2015
        /// </summary>
        [Description("vs2015")]
        VisualStudio2015,
        /// <summary>
        /// The xcode
        /// </summary>
        [Description("xcode")]
        XCode,
        /// <summary>
        /// The XT256
        /// </summary>
        [Description("xt256")]
        xt256
    }
}
