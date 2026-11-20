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
type MidletExitProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable midlet : MIDlet
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MidletExitProcessor.jclinitDone then
            MidletExitProcessor.jclinitDone <- true
            MidletExitProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (midlet: MIDlet) as this =
        { inherit Processor() }
        then
            this.jctor1(midlet)
    member this.jctor1(midlet: MIDlet) : unit =
        this.midlet <- midlet
        ()
    
    override this.process_() : unit =
        ignore (JSystem.exit(0))


