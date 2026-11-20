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
type CurrentDisplayableFactory =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable canvasStrings : CanvasStrings
    [<DefaultValue(false)>] val mutable stringUtil : StringUtil
    [<DefaultValue(false)>] val mutable SET_DISPLAYABLE : string
    [<DefaultValue(false)>] val mutable SET_RUNNABLE : string
    [<DefaultValue(false)>] val mutable CLEAR_RUNNABLE : string
    [<DefaultValue(false)>] val mutable SET_USED_RUNNABLE : string
    [<DefaultValue(false)>] val mutable RUNNABLE : string
    [<DefaultValue(false)>] val mutable RUNNABLE_WAS_ALREADY_IN_USE : string
    [<DefaultValue(false)>] val mutable DEFAULT_CHILD_NAME_LIST : BasicArrayList
    [<DefaultValue(false)>] val mutable displayable : Displayable
    [<DefaultValue(false)>] val mutable openGlReadydisplayable : Displayable
    [<DefaultValue(false)>] val mutable runnable : GameRunnable
    [<DefaultValue(false)>] val mutable usedRunnable : GameRunnable
    [<DefaultValue(false)>] static val mutable private jcell_instance : CurrentDisplayableFactory
    static member instance with get() : CurrentDisplayableFactory = (CurrentDisplayableFactory.jclinit(); CurrentDisplayableFactory.jcell_instance) and set (jvalue: CurrentDisplayableFactory) = (CurrentDisplayableFactory.jclinit(); CurrentDisplayableFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CurrentDisplayableFactory.jclinitDone then
            CurrentDisplayableFactory.jclinitDone <- true
            CurrentDisplayableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CurrentDisplayableFactory.jcell_instance <- (new CurrentDisplayableFactory())
        ()
    member this.jfields_CurrentDisplayableFactory() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.canvasStrings <- CanvasStrings.getInstance()
        this.stringUtil <- StringUtil.getInstance()
        this.SET_DISPLAYABLE <- "setDisplayable"
        this.SET_RUNNABLE <- "setRunnable"
        this.CLEAR_RUNNABLE <- "clearRunnable"
        this.SET_USED_RUNNABLE <- "setUsedRunnable"
        this.RUNNABLE <- "Runnable: "
        this.RUNNABLE_WAS_ALREADY_IN_USE <- "Runnable was already in use: "
        this.DEFAULT_CHILD_NAME_LIST <- (new BasicArrayListD())
        this.displayable <- NullDisplayable.getInstance()
        this.openGlReadydisplayable <- NullDisplayable.getInstance()
        this.runnable <- NullWaitGameRunnable.getInstance()
        this.usedRunnable <- NullWaitGameRunnable.getInstance()
        ()
    
    static member getInstance() : CurrentDisplayableFactory =
        CurrentDisplayableFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_CurrentDisplayableFactory()
            this.jctor1()
    member this.jctor1() : unit =
        ignore (this.DEFAULT_CHILD_NAME_LIST.add(this.canvasStrings.ABOUT))
        ignore (this.DEFAULT_CHILD_NAME_LIST.add(this.canvasStrings.OPTIONS))
        ignore (this.DEFAULT_CHILD_NAME_LIST.add(GameInputMappingCanvas.NAME))
        ignore (this.DEFAULT_CHILD_NAME_LIST.add(GameInputMappingInstructionsCanvas.NAME))
        ignore (this.DEFAULT_CHILD_NAME_LIST.add(HighScoresCanvas.NAME))
        ()
    
    abstract setMyCanvas : displayable: MyCanvas -> unit
    default this.setMyCanvas(displayable: MyCanvas) : unit =
        let mutable jflow = 0
        if (box (this.displayable) :? MyCanvas) then
            if displayable.hasChild((box (this.displayable) :?> MyCanvas)) then
                PreLogUtil.put((new StringMaker()).append("Child Displayable is already set for: ").append(this.stringUtil.toString(displayable)).ToString(), this, this.SET_DISPLAYABLE)
                jflow <- 1
        if jflow = 0 then
            this.setDisplayable(displayable)
    
    abstract setDisplayable : displayable: Displayable -> unit
    default this.setDisplayable(displayable: Displayable) : unit =
        this.displayable <- displayable
        this.setOpenGlReadydisplayable(displayable)
    
    abstract setOpenGlReadydisplayable : openGlReadydisplayable: Displayable -> unit
    default this.setOpenGlReadydisplayable(openGlReadydisplayable: Displayable) : unit =
        this.openGlReadydisplayable <- openGlReadydisplayable
        this.update()
    
    abstract getOpenGlReadydisplayable : unit -> Displayable
    default this.getOpenGlReadydisplayable() : Displayable =
        this.openGlReadydisplayable
    
    abstract setRunnable : runnable: GameRunnable -> unit
    default this.setRunnable(runnable: GameRunnable) : unit =
        PreLogUtil.put((new StringMaker()).append(this.RUNNABLE).append(this.stringUtil.toString(runnable)).ToString(), this, this.SET_RUNNABLE)
        this.runnable <- runnable
        if not (JR.same(this.usedRunnable, this.runnable)) then
            this.update()
        else
            PreLogUtil.put((new StringMaker()).append(this.RUNNABLE_WAS_ALREADY_IN_USE).append(this.stringUtil.toString(runnable)).ToString(), this, this.SET_RUNNABLE)
    
    abstract clearRunnable : unit -> unit
    default this.clearRunnable() : unit =
        PreLogUtil.put((new StringMaker()).append(this.RUNNABLE).append(this.stringUtil.toString(NullRunnable.getInstance())).ToString(), this, this.CLEAR_RUNNABLE)
        this.setUsedRunnable(NullWaitGameRunnable.getInstance())
    
    member this.update() : unit =
        if true then
            let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
            let mutable features : Features = Features.getInstance()
            let mutable stringMaker : StringMaker = (new StringMaker())
            ignore (stringMaker.append(this.stringUtil.toString(this.openGlReadydisplayable)))
            if SWTUtil.isSWT && (not (features.isDefault(OpenGLFeatureFactory.getInstance().OPENGL))) then
                PreLogUtil.put(stringMaker.append(commonSeps.SPACE).append(SWTUtil.SWT).append(commonSeps.SPACE).append(this.RUNNABLE).append(this.stringUtil.toString(NullRunnable.getInstance())).ToString(), this, this.commonStrings.UPDATE)
                this.setUsedRunnable(NullWaitGameRunnable.getInstance())
            elif J2MEUtil.isHTML() then
                PreLogUtil.put(stringMaker.append(commonSeps.SPACE).append(GraphicsStrings.getInstance().HTML).append(commonSeps.SPACE).append(this.RUNNABLE).append(this.stringUtil.toString(this.runnable)).ToString(), this, this.commonStrings.UPDATE)
                this.setUsedRunnable(this.runnable)
            elif (((box (this.openGlReadydisplayable) :? DemoCanvas)) || ((box (this.openGlReadydisplayable) :? AllBinaryGameCanvas))) || features.isDefault(OpenGLFeatureFactory.getInstance().OPENGL) then
                PreLogUtil.put(stringMaker.append(commonSeps.SPACE).append(OpenGLFeatureFactory.getInstance().OPENGL.ToString()).append(commonSeps.SPACE).append(this.RUNNABLE).append(this.stringUtil.toString(this.runnable)).ToString(), this, this.commonStrings.UPDATE)
                this.setUsedRunnable(this.runnable)
            else
                PreLogUtil.put(stringMaker.append(this.RUNNABLE).append(this.stringUtil.toString(NullRunnable.getInstance())).ToString(), this, this.commonStrings.UPDATE)
                this.setUsedRunnable(NullWaitGameRunnable.getInstance())
    
    abstract getDisplayable : unit -> Displayable
    default this.getDisplayable() : Displayable =
        this.displayable
    
    abstract getUsedRunnable : unit -> GameRunnable
    default this.getUsedRunnable() : GameRunnable =
        this.usedRunnable
    
    abstract setUsedRunnable : usedRunnable: GameRunnable -> unit
    default this.setUsedRunnable(usedRunnable: GameRunnable) : unit =
        PreLogUtil.put((new StringMaker()).append(this.RUNNABLE).append(this.stringUtil.toString(this.runnable)).append(CommonSeps.getInstance().COLON_SEP).append(this.stringUtil.toString(usedRunnable)).ToString(), this, this.SET_USED_RUNNABLE)
        this.usedRunnable <- usedRunnable


