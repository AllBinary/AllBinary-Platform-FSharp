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
type FullScreenUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : FullScreenUtil
    static member instance with get() : FullScreenUtil = (FullScreenUtil.jclinit(); FullScreenUtil.jcell_instance) and set (jvalue: FullScreenUtil) = (FullScreenUtil.jclinit(); FullScreenUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FullScreenUtil.jclinitDone then
            FullScreenUtil.jclinitDone <- true
            FullScreenUtil.jclinitBody()
    static member private jclinitBody() : unit =
        FullScreenUtil.jcell_instance <- (new FullScreenUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : FullScreenUtil =
        FullScreenUtil.instance
    
    member this.initOnRun(fullScreenInterface: Canvas, commandListener: CommandListener) : unit =
        if not (JR.same(commandListener, null)) then
            this.init(fullScreenInterface)
    
    member this.init(fullScreenInterface: Canvas) : unit =
        ()
    
    member this.isScreenChange(isFullScreen: bool) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable mainFeatureFactory : MainFeatureFactory = MainFeatureFactory.getInstance()
        let mutable features : Features = Features.getInstance()
        if features.isFeature(mainFeatureFactory.FULL_SCREEN) <> isFullScreen then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    member this.isScreenChangeCanvas(fullScreenInterface: Canvas) : bool =
        this.isScreenChange(false)


