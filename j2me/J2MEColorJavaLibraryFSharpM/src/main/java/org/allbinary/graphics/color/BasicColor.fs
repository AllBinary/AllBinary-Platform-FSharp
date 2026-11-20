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
type BasicColor =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable value : int
    [<DefaultValue(false)>] val mutable redComponent : float32
    [<DefaultValue(false)>] val mutable greenComponent : float32
    [<DefaultValue(false)>] val mutable blueComponent : float32
    [<DefaultValue(false)>] val mutable alphaComponent : float32
    [<DefaultValue(false)>] val mutable red : int16
    [<DefaultValue(false)>] val mutable green : int16
    [<DefaultValue(false)>] val mutable blue : int16
    [<DefaultValue(false)>] val mutable alpha : int16
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicColor.jclinitDone then
            BasicColor.jclinitDone <- true
            BasicColor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (alphaValue: int, value: int, name: string) as this =
        {  }
        then
            this.jctor1(alphaValue, value, name)
    member this.jctor1(alphaValue: int, value: int, name: string) : unit =
        this.name <- name
        let mutable tempValue : int = 0
        let mutable basicColorUtil : BasicColorUtil = BasicColorUtil.getInstance()
        if basicColorUtil.isAlpha then
            if basicColorUtil.ffOpaque then
                tempValue <- alphaValue ||| value
            else
                tempValue <- 0x00000000 ||| value
        else
            tempValue <- value
        let mutable alphaInt : int = ((tempValue >>> 24) &&& 255)
        this.alpha <- int16 (alphaInt)
        this.alphaComponent <- (float32 (alphaInt)) / 255.0f
        let mutable redInt : int = ((tempValue >>> 16) &&& 255)
        this.red <- int16 (redInt)
        this.redComponent <- (float32 (redInt)) / 255.0f
        let mutable greenInt : int = ((tempValue >>> 8) &&& 255)
        this.green <- int16 (greenInt)
        this.greenComponent <- (float32 (greenInt)) / 255.0f
        let mutable blueInt : int = ((tempValue) &&& 255)
        this.blue <- int16 (blueInt)
        this.blueComponent <- (float32 (blueInt)) / 255.0f
        this.value <- tempValue
        ()
    
    abstract intValue : unit -> int
    default this.intValue() : int =
        this.value
    
    abstract toInt : unit -> int
    default this.toInt() : int =
        this.value
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("BasicColor: "))
        ignore (stringBuffer.append("Alpha: "))
        ignore (stringBuffer.appendshort(this.alpha))
        ignore (stringBuffer.append(" Red: "))
        ignore (stringBuffer.appendshort(this.red))
        ignore (stringBuffer.append(" Green: "))
        ignore (stringBuffer.appendshort(this.green))
        ignore (stringBuffer.append(" Blue: "))
        ignore (stringBuffer.appendshort(this.blue))
        ignore (stringBuffer.append(" Value: "))
        ignore (stringBuffer.appendint(this.value))
        stringBuffer.ToString()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract getRedComponent : unit -> float32
    default this.getRedComponent() : float32 =
        this.redComponent
    
    abstract getGreenComponent : unit -> float32
    default this.getGreenComponent() : float32 =
        this.greenComponent
    
    abstract getBlueComponent : unit -> float32
    default this.getBlueComponent() : float32 =
        this.blueComponent
    
    abstract getAlphaComponent : unit -> float32
    default this.getAlphaComponent() : float32 =
        this.alphaComponent


