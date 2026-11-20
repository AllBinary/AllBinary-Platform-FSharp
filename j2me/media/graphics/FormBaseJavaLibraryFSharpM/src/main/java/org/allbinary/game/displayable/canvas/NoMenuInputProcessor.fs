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
type NoMenuInputProcessor =
    inherit BasicMenuInputProcessor
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NoMenuInputProcessor
    static member SINGLETON with get() : NoMenuInputProcessor = (NoMenuInputProcessor.jclinit(); NoMenuInputProcessor.jcell_SINGLETON) and set (jvalue: NoMenuInputProcessor) = (NoMenuInputProcessor.jclinit(); NoMenuInputProcessor.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoMenuInputProcessor.jclinitDone then
            NoMenuInputProcessor.jclinitDone <- true
            NoMenuInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        NoMenuInputProcessor.jcell_SINGLETON <- (new NoMenuInputProcessor())
        ()
    
    static member getInstance() : NoMenuInputProcessor =
        NoMenuInputProcessor.SINGLETON
    
    new () =
        { inherit BasicMenuInputProcessor(BasicArrayListUtil.getInstance().getImmutableInstance(), -1, NullCanvas.NULL_CANVAS) }
    
    override this.onDownGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    override this.onUpGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    override this.onMotionGestureEvent(motionGestureEvent: MotionGestureEvent) : unit =
        ()


