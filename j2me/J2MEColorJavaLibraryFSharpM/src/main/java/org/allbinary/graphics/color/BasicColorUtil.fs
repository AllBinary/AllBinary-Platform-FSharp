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
type BasicColorUtil =
    [<DefaultValue(false)>] val mutable ZERO_ARRAY : BasicColor[]
    [<DefaultValue(false)>] val mutable ALPHA : int
    [<DefaultValue(false)>] val mutable isAlpha : bool
    [<DefaultValue(false)>] val mutable ffOpaque : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicColorUtil
    static member instance with get() : BasicColorUtil = (BasicColorUtil.jclinit(); BasicColorUtil.jcell_instance) and set (jvalue: BasicColorUtil) = (BasicColorUtil.jclinit(); BasicColorUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicColorUtil.jclinitDone then
            BasicColorUtil.jclinitDone <- true
            BasicColorUtil.jclinitBody()
    static member private jclinitBody() : unit =
        BasicColorUtil.jcell_instance <- (new BasicColorUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicColorUtil()
    member this.jfields_BasicColorUtil() : unit =
        this.ZERO_ARRAY <- (Array.zeroCreate<BasicColor> (0))
        this.ALPHA <- 0xFF000000
        this.isAlpha <- true
        this.ffOpaque <- true
        ()
    
    static member getInstance() : BasicColorUtil =
        BasicColorUtil.instance
    
    abstract getRGB : red: int * green: int * blue: int -> int
    default this.getRGB(red: int, green: int, blue: int) : int =
        let mutable value : int = 0
        if this.isAlpha then
            if this.ffOpaque then
                value <- this.ALPHA
        value <- (red <<< 16) ||| value
        value <- (green <<< 8) ||| value
        value <- blue ||| value
        value
    
    abstract getARGB : alphaValue: int * r: int * g: int * b: int -> int
    default this.getARGB(alphaValue: int, r: int, g: int, b: int) : int =
        ((((alphaValue <<< 24) &&& this.ALPHA) + ((r <<< 16) &&& 0x00FF0000)) + ((g <<< 8) &&& 0x0000FF00)) + (b &&& 0x000000FF)
    
    abstract get : alphaValue: int * color: int -> int
    default this.get(alphaValue: int, color: int) : int =
        ((alphaValue <<< 24) &&& this.ALPHA) + color
    
    abstract invert : color: int -> int
    default this.invert(color: int) : int =
        (0xFFFFFF - color) ||| this.ALPHA


