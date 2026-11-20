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
type ColorChangeEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ColorChangeEvent.jclinitDone then
            ColorChangeEvent.jclinitDone <- true
            ColorChangeEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ColorChangeEvent() : unit =
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        ()
    
    new (anyType: obj) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jfields_ColorChangeEvent()
    
    abstract setBasicColorP : basicColor: BasicColor -> unit
    default this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor


