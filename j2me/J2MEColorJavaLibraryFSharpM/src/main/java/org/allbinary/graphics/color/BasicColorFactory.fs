namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type BasicColorFactory =
    [<DefaultValue(false)>] val mutable NULL_COLOR : BasicColor
    [<DefaultValue(false)>] val mutable TAN : BasicColor
    [<DefaultValue(false)>] val mutable SKIN_PINK : BasicColor
    [<DefaultValue(false)>] val mutable RED : BasicColor
    [<DefaultValue(false)>] val mutable LIGHT_RED : BasicColor
    [<DefaultValue(false)>] val mutable DARK_GREEN : BasicColor
    [<DefaultValue(false)>] val mutable GREEN : BasicColor
    [<DefaultValue(false)>] val mutable LIGHT_GREEN : BasicColor
    [<DefaultValue(false)>] val mutable PURPLE : BasicColor
    [<DefaultValue(false)>] val mutable BLUE : BasicColor
    [<DefaultValue(false)>] val mutable LIGHT_BLUE : BasicColor
    [<DefaultValue(false)>] val mutable VERY_LIGHT_BLUE : BasicColor
    [<DefaultValue(false)>] val mutable PUCE : BasicColor
    [<DefaultValue(false)>] val mutable AQUA : BasicColor
    [<DefaultValue(false)>] val mutable YELLOW : BasicColor
    [<DefaultValue(false)>] val mutable PINK : BasicColor
    [<DefaultValue(false)>] val mutable BLACK : BasicColor
    [<DefaultValue(false)>] val mutable GREY : BasicColor
    [<DefaultValue(false)>] val mutable LIGHT_GREY : BasicColor
    [<DefaultValue(false)>] val mutable DARK_GREY : BasicColor
    [<DefaultValue(false)>] val mutable ORANGE : BasicColor
    [<DefaultValue(false)>] val mutable BROWN : BasicColor
    [<DefaultValue(false)>] val mutable WHITE : BasicColor
    [<DefaultValue(false)>] val mutable TRANSPARENT_COLOR : BasicColor
    [<DefaultValue(false)>] val mutable TRANSPARENT_GREY : BasicColor
    [<DefaultValue(false)>] val mutable TRANSPARENT_BLACK : BasicColor
    [<DefaultValue(false)>] val mutable TRANSPARENT_RED : BasicColor
    [<DefaultValue(false)>] val mutable CLEAR_COLOR : BasicColor
    [<DefaultValue(false)>] val mutable BORDER_COLOR : BasicColor
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicColorFactory
    static member instance with get() : BasicColorFactory = (BasicColorFactory.jclinit(); BasicColorFactory.jcell_instance) and set (jvalue: BasicColorFactory) = (BasicColorFactory.jclinit(); BasicColorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicColorFactory.jclinitDone then
            BasicColorFactory.jclinitDone <- true
            BasicColorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicColorFactory.jcell_instance <- (new BasicColorFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicColorFactory()
    member this.jfields_BasicColorFactory() : unit =
        this.NULL_COLOR <- this.createInstanceARGB(255, 255, 255, 255, "null color")
        this.TAN <- this.createInstance(0xE9D8B5)
        this.SKIN_PINK <- this.createInstance(0xFDCECE)
        this.RED <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0xFF0000, "red")
        this.LIGHT_RED <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0xFFA0A0, "light red")
        this.DARK_GREEN <- this.createInstance(0x00FF00)
        this.GREEN <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0x00DD00, "green")
        this.LIGHT_GREEN <- this.createInstance(0x007700)
        this.PURPLE <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0x400040, "purple")
        this.BLUE <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0x0000FF, "blue")
        this.LIGHT_BLUE <- this.createInstance(0x00aaff)
        this.VERY_LIGHT_BLUE <- this.createInstance(0x000033)
        this.PUCE <- this.createInstance(0xFF00AA)
        this.AQUA <- this.createInstance(0x00FFFF)
        this.YELLOW <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0xFFFF00, "yellow")
        this.PINK <- this.createInstance(0xFF00FF)
        this.BLACK <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0x000000, "black")
        this.GREY <- this.createInstanceAN(BasicColorUtil.getInstance().ALPHA, 0xAAAAAA, "grey")
        this.LIGHT_GREY <- this.createInstance(0xC0C0C0)
        this.DARK_GREY <- this.createInstance(0x404040)
        this.ORANGE <- this.createInstance(0xe07718)
        this.BROWN <- this.createInstance(0x956B00)
        this.WHITE <- this.createInstance(0xFFFFFF)
        this.TRANSPARENT_COLOR <- this.createInstanceAN(0x00000000, 0x000000, StringUtil.getInstance().EMPTY_STRING)
        this.TRANSPARENT_GREY <- this.createInstanceAN(0x52000000, 0xECECEC, StringUtil.getInstance().EMPTY_STRING)
        this.TRANSPARENT_BLACK <- this.createInstanceAN(0x52000000, 0x000000, StringUtil.getInstance().EMPTY_STRING)
        this.TRANSPARENT_RED <- this.createInstanceAN(0x52000000, 0xFF0000, StringUtil.getInstance().EMPTY_STRING)
        this.CLEAR_COLOR <- this.BLACK
        this.BORDER_COLOR <- this.WHITE
        ()
    
    static member getInstance() : BasicColorFactory =
        BasicColorFactory.instance
    
    abstract createInstance : value: int -> BasicColor
    default this.createInstance(value: int) : BasicColor =
        (new BasicColor(BasicColorUtil.getInstance().ALPHA, value, StringUtil.getInstance().EMPTY_STRING))
    
    abstract createInstanceA : alphaValue: int * value: int -> BasicColor
    default this.createInstanceA(alphaValue: int, value: int) : BasicColor =
        (new BasicColor(alphaValue, value, StringUtil.getInstance().EMPTY_STRING))
    
    abstract createInstanceAN : alphaValue: int * value: int * name: string -> BasicColor
    default this.createInstanceAN(alphaValue: int, value: int, name: string) : BasicColor =
        (new BasicColor(alphaValue, value, name))
    
    abstract createInstanceARGB : alphaValue: int * r: int * g: int * b: int * name: string -> BasicColor
    default this.createInstanceARGB(alphaValue: int, r: int, g: int, b: int, name: string) : BasicColor =
        let mutable ALPHA_MASK : int = 0xFF000000
        (new BasicColor(alphaValue, (((((alphaValue <<< 24) &&& ALPHA_MASK) + ((r <<< 16) &&& 0x00FF0000)) + ((g <<< 8) &&& 0x0000FF00)) + (b &&& 0x000000FF)), StringUtil.getInstance().EMPTY_STRING))


