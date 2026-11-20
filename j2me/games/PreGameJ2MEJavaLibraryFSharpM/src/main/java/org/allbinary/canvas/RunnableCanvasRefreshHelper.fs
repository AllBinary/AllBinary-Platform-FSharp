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
type RunnableCanvasRefreshHelper =
    inherit Processor
    [<DefaultValue(false)>] val mutable runnableCanvas : MyCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RunnableCanvasRefreshHelper.jclinitDone then
            RunnableCanvasRefreshHelper.jclinitDone <- true
            RunnableCanvasRefreshHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (runnableCanvas: MyCanvas) as this =
        { inherit Processor() }
        then
            this.jctor1(runnableCanvas)
    member this.jctor1(runnableCanvas: MyCanvas) : unit =
        this.runnableCanvas <- runnableCanvas
        ()
    
    override this.process_() : unit =
        this.runnableCanvas.repaint()


