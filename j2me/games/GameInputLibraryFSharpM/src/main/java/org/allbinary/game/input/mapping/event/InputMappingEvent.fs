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
type InputMappingEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputMappingEvent.jclinitDone then
            InputMappingEvent.jclinitDone <- true
            InputMappingEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_InputMappingEvent() : unit =
        this.inputToGameKeyMapping <- InputToGameKeyMapping.getNullInstance()
        ()
    
    new (anyType: obj) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jfields_InputMappingEvent()
    
    abstract setInputToGameKeyMapping : inputToGameKeyMapping: InputToGameKeyMapping -> unit
    default this.setInputToGameKeyMapping(inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        this.inputToGameKeyMapping <- inputToGameKeyMapping
    
    abstract getInputToGameKeyMapping : unit -> InputToGameKeyMapping
    default this.getInputToGameKeyMapping() : InputToGameKeyMapping =
        this.inputToGameKeyMapping


