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
type InputProcessor =
    [<DefaultValue(false)>] val mutable gameInputStrings : GameInputStrings
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputProcessor.jclinitDone then
            InputProcessor.jclinitDone <- true
            InputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_InputProcessor()
    member this.jfields_InputProcessor() : unit =
        this.gameInputStrings <- GameInputStrings.getInstance()
        ()
    
    abstract keyPressedByDevice : keyCode: int * deviceId: int -> unit
    default this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        ()
    
    abstract keyReleasedByDevice : canvas: Canvas * keyCode: int * deviceId: int -> unit
    default this.keyReleasedByDevice(canvas: Canvas, keyCode: int, deviceId: int) : unit =
        ()


