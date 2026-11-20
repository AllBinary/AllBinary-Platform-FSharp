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
type EarlySoundsFactory =
    inherit BaseSoundsFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : EarlySoundsFactory
    static member instance with get() : EarlySoundsFactory = (EarlySoundsFactory.jclinit(); EarlySoundsFactory.jcell_instance) and set (jvalue: EarlySoundsFactory) = (EarlySoundsFactory.jclinit(); EarlySoundsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EarlySoundsFactory.jclinitDone then
            EarlySoundsFactory.jclinitDone <- true
            EarlySoundsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        EarlySoundsFactory.jcell_instance <- (new EarlySoundsFactory())
        ()
    new () =
        { inherit BaseSoundsFactory() }
    
    override this.getSoundInterfaceArray() : Sound[] =
        let mutable soundInterfaceArray : Sound[] = (Array.zeroCreate<Sound> (2))
        let mutable index : int = 0
        soundInterfaceArray.[(let jt = index in index <- index + 1; jt)] <- SelectSound.getInstance()
        soundInterfaceArray.[(let jt = index in index <- index + 1; jt)] <- ErrorSound.getInstance()
        soundInterfaceArray
    
    static member getInstance() : EarlySoundsFactory =
        EarlySoundsFactory.instance


