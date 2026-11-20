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
type ScreenRepaintProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable displayable : Displayable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenRepaintProcessor.jclinitDone then
            ScreenRepaintProcessor.jclinitDone <- true
            ScreenRepaintProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (displayable: Displayable) as this =
        { inherit Processor() }
        then
            this.jctor1(displayable)
    member this.jctor1(displayable: Displayable) : unit =
        this.displayable <- displayable
        ()
    
    override this.process_() : unit =
        ScreenRepaintUtil.repaint(this.displayable)


