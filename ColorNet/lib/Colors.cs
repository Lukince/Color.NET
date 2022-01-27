namespace ColorNet
{
    public enum ColorPad : int
    {
        Black    = 0,
        Red      = 1,
        Green    = 2,
        Yellow   = 3,
        Blue     = 4,
        Magenta  = 5,
        Cyan     = 6,
        White    = 7,
        //Reserved 8,
        Reset    = 9
    }
        
    public enum ColorLayer : int
    {
        Foreground = 30,
        Background = 40
    }
        
    public enum ColorProperty : int
    {
        Reset                     =  0,
        Bold                      =  1,
        Dim                       =  2,
        Italic                    =  3,
        Underline                 =  4,
        SlowBlink                 =  5,
        RapidBlink                =  6,
        Reverse                   =  7,
        Concealed                 =  8,
        Strike                    =  9,
        DefaultFont               = 10,
        Fraktur                   = 20,
        OffBoldAndDoubleUnderline = 21,
        Normal                    = 22,
        OffItalicAndFraktur       = 23,
        OffUnderline              = 24,
        OffBlink                  = 25,
        ProportionalSpacing       = 26,
        OffReserve                = 27,
        OffConcealed              = 28,
        OffStrike                 = 29,
        // ...
        OffProportionalSpacing    = 50,
        Framed                    = 51,
        Encircled                 = 52,
        Overlined                 = 53,
        OffFrameAndEncircled      = 54,
        OffOverlined              = 55,
        // ... Ideogram attributes
        IdeUnderline              = 60,
        IdeDoubleUnder            = 61,
        IdeOverline               = 62,
        IdeDoubleOverline         = 63,
        IdeStressMarking          = 64,
        IdeOff                    = 65,
        // ... scription
        Superscript               = 73,
        Subscript                 = 74,
        ScriptOff                 = 75
    }
}