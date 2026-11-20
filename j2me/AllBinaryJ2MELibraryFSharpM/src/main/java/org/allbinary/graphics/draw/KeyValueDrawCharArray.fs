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
type KeyValueDrawCharArray =
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable LABEL : string
    [<DefaultValue(false)>] val mutable labelX : int
    [<DefaultValue(false)>] val mutable valueX : int
    [<DefaultValue(false)>] val mutable value : char[]
    [<DefaultValue(false)>] val mutable len : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyValueDrawCharArray.jclinitDone then
            KeyValueDrawCharArray.jclinitDone <- true
            KeyValueDrawCharArray.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_KeyValueDrawCharArray() : unit =
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.value <- CharArrayFactory.getInstance().getZeroCharArray()
        ()
    
    new (label: string, x: int) as this =
        {  }
        then
            this.jfields_KeyValueDrawCharArray()
            this.jctor1(label, x)
    member this.jctor1(label: string, x: int) : unit =
        this.LABEL <- label
        this.labelX <- x
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable labelWidth : int = graphics.getFont().stringWidth(this.LABEL) - JString.length(this.LABEL)
        this.valueX <- labelWidth + this.labelX
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract paint : graphics: Graphics * y: int -> unit
    default this.paint(graphics: Graphics, y: int) : unit =
        this.myFontProcessor.process_(graphics)
        graphics.drawString(this.LABEL, this.labelX, y, 0)
        graphics.drawChars(this.value, 0, this.len, this.valueX, y, 0)
    
    abstract update : value: char[] * len: int -> unit
    default this.update(value: char[], len: int) : unit =
        this.value <- value
        this.len <- len
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


