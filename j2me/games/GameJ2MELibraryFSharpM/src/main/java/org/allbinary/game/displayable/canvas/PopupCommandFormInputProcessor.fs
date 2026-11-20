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
type PopupCommandFormInputProcessor =
    inherit CommandFormInputProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PopupCommandFormInputProcessor.jclinitDone then
            PopupCommandFormInputProcessor.jclinitDone <- true
            PopupCommandFormInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: MyCanvas, form: ScrollSelectionForm, popupMenuInputProcessor: PopupMenuInputProcessor) =
        { inherit CommandFormInputProcessor(gameKeyEventList, playerInputId, gameCanvas, form) }
    
    override this.processInput(key: int) : int =
        base.processInput(key)
    
    override this.processMotionInput(motionGestureEvent: MotionGestureEvent) : unit =
        base.processMotionInput(motionGestureEvent)


