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
type GameCanvasPauseRunnable =
    inherit GameRunnable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable allBinaryGameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameCanvasPauseRunnable.jclinitDone then
            GameCanvasPauseRunnable.jclinitDone <- true
            GameCanvasPauseRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameCanvasPauseRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (allBinaryGameCanvas: AllBinaryGameCanvas) as this =
        { inherit GameRunnable() }
        then
            this.jfields_GameCanvasPauseRunnable()
            this.jctor1(allBinaryGameCanvas)
    member this.jctor1(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        this.allBinaryGameCanvas <- allBinaryGameCanvas
        ()
    
    override this.run() : unit =
        ()
    
    override this.processLoopSleep() : unit =
        try
            let mutable features : Features = Features.getInstance()
            let mutable isOpenGL : bool = features.isDefault(OpenGLFeatureFactory.getInstance().OPENGL)
            if isOpenGL then
                this.allBinaryGameCanvas.processSleep()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()


