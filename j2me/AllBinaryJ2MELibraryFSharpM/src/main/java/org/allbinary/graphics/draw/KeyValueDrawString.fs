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
type KeyValueDrawString =
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable LABEL : string
    [<DefaultValue(false)>] val mutable labelX : int
    [<DefaultValue(false)>] val mutable valueX : int
    [<DefaultValue(false)>] val mutable value : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyValueDrawString.jclinitDone then
            KeyValueDrawString.jclinitDone <- true
            KeyValueDrawString.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_KeyValueDrawString() : unit =
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.value <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (label: string, x: int) as this =
        {  }
        then
            this.jfields_KeyValueDrawString()
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
        graphics.drawString(this.value, this.valueX, y, 0)
    
    abstract update : value: string -> unit
    default this.update(value: string) : unit =
        this.value <- value
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


