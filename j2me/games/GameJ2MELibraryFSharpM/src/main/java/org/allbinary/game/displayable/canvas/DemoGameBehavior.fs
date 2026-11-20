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
type DemoGameBehavior =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : DemoGameBehavior
    static member instance with get() : DemoGameBehavior = (DemoGameBehavior.jclinit(); DemoGameBehavior.jcell_instance) and set (jvalue: DemoGameBehavior) = (DemoGameBehavior.jclinit(); DemoGameBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameBehavior.jclinitDone then
            DemoGameBehavior.jclinitDone <- true
            DemoGameBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        DemoGameBehavior.jcell_instance <- (new DemoGameBehavior())
        ()
    new () as this =
        {  }
        then
            this.jfields_DemoGameBehavior()
    member this.jfields_DemoGameBehavior() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : DemoGameBehavior =
        DemoGameBehavior.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract pause : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.pause(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract unPause : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.unPause(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract updateTouch : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.updateTouch(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract updateScreenButtonPaintable : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.updateScreenButtonPaintable(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.setTouchPaintableP(NullPaintable.getInstance())
    
    abstract setGameState : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.setGameState(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract removeAllGameKeyInputListeners : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.removeAllGameKeyInputListeners(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract updateEndGameProcessor : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.updateEndGameProcessor(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract buildGame : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.buildGame(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract run : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.run(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF(GameTypeFactory.getInstance().BOT.ToString(), this, commonStrings.RUN)
    
    abstract setHighScore : abeClientInformation: AbeClientInformationInterface * allBinaryGameCanvas: AllBinaryGameCanvas * name: string * score: int64 * autoSubmit: bool * isLast: bool -> unit
    default this.setHighScore(abeClientInformation: AbeClientInformationInterface, allBinaryGameCanvas: AllBinaryGameCanvas, name: string, score: int64, autoSubmit: bool, isLast: bool) : unit =
        ()


