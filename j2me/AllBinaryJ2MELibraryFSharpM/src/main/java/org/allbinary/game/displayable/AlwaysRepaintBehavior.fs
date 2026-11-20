namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type AlwaysRepaintBehavior =
    inherit RepaintBehavior
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : AlwaysRepaintBehavior
    static member instanceC with get() : AlwaysRepaintBehavior = (AlwaysRepaintBehavior.jclinit(); AlwaysRepaintBehavior.jcell_instanceC) and set (jvalue: AlwaysRepaintBehavior) = (AlwaysRepaintBehavior.jclinit(); AlwaysRepaintBehavior.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AlwaysRepaintBehavior.jclinitDone then
            AlwaysRepaintBehavior.jclinitDone <- true
            AlwaysRepaintBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        AlwaysRepaintBehavior.jcell_instanceC <- (new AlwaysRepaintBehavior())
        ()
    new () as this =
        { inherit RepaintBehavior() }
        then
            this.jfields_AlwaysRepaintBehavior()
    member this.jfields_AlwaysRepaintBehavior() : unit =
        this.NAME <- "AlwaysRepaintBehavior"
        ()
    
    static member getInstance() : AlwaysRepaintBehavior =
        AlwaysRepaintBehavior.instanceC
    
    override this.repaint(canvas: Canvas) : unit =
        let mutable features : Features = Features.getInstance()
        let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
        if features.isFeature(openGLFeatureFactory.OPENGL) then
            DisplayInfoSingleton.getInstance().process_()
        else
            let mutable thread : Thread = (new Thread((new RepaintRunnable(canvas)), this.NAME))
            ignore (thread.start())
    
    override this.onChangeRepaint(canvas: Canvas) : unit =
        ()


