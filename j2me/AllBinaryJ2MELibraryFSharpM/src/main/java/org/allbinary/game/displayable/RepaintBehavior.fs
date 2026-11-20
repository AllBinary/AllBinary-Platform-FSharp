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
type RepaintBehavior =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : RepaintBehavior
    static member instance with get() : RepaintBehavior = (RepaintBehavior.jclinit(); RepaintBehavior.jcell_instance) and set (jvalue: RepaintBehavior) = (RepaintBehavior.jclinit(); RepaintBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RepaintBehavior.jclinitDone then
            RepaintBehavior.jclinitDone <- true
            RepaintBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        RepaintBehavior.jcell_instance <- (new RepaintBehavior())
        ()
    new () as this =
        {  }
        then
            this.jfields_RepaintBehavior()
    member this.jfields_RepaintBehavior() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.NAME <- "RepaintBehavior"
        ()
    
    static member getInstance() : RepaintBehavior =
        RepaintBehavior.instance
    
    abstract repaint : canvas: Canvas -> unit
    default this.repaint(canvas: Canvas) : unit =
        ()
    
    abstract onChangeRepaint : canvas: Canvas -> unit
    default this.onChangeRepaint(canvas: Canvas) : unit =
        let mutable features : Features = Features.getInstance()
        let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
        if features.isFeature(openGLFeatureFactory.OPENGL) then
            DisplayInfoSingleton.getInstance().process_()
        else
            let mutable thread : Thread = (new Thread((new RepaintRunnable(canvas)), this.NAME))
            ignore (thread.start())


