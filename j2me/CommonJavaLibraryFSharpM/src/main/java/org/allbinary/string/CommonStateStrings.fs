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
type CommonStateStrings =
    [<DefaultValue(false)>] val mutable CONTEXT : string
    [<DefaultValue(false)>] val mutable FINISH : string
    [<DefaultValue(false)>] val mutable CREATE : string
    [<DefaultValue(false)>] val mutable START : string
    [<DefaultValue(false)>] val mutable RESTART : string
    [<DefaultValue(false)>] val mutable RESUME : string
    [<DefaultValue(false)>] val mutable PAUSE : string
    [<DefaultValue(false)>] val mutable STOP : string
    [<DefaultValue(false)>] val mutable DESTROY : string
    [<DefaultValue(false)>] val mutable BIND : string
    [<DefaultValue(false)>] val mutable ON_SAVE_INSTANCE_STATE : string
    [<DefaultValue(false)>] val mutable ON_START_COMMAND : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommonStateStrings
    static member instance with get() : CommonStateStrings = (CommonStateStrings.jclinit(); CommonStateStrings.jcell_instance) and set (jvalue: CommonStateStrings) = (CommonStateStrings.jclinit(); CommonStateStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonStateStrings.jclinitDone then
            CommonStateStrings.jclinitDone <- true
            CommonStateStrings.jclinitBody()
    static member private jclinitBody() : unit =
        CommonStateStrings.jcell_instance <- (new CommonStateStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_CommonStateStrings()
    member this.jfields_CommonStateStrings() : unit =
        this.CONTEXT <- "Context: "
        this.FINISH <- "finish"
        this.CREATE <- "onCreate"
        this.START <- "onStart"
        this.RESTART <- "onRestart"
        this.RESUME <- "onResume"
        this.PAUSE <- "onPause"
        this.STOP <- "onStop"
        this.DESTROY <- "onDestroy"
        this.BIND <- "onBind"
        this.ON_SAVE_INSTANCE_STATE <- "onSaveInstanceState"
        this.ON_START_COMMAND <- "onStartCommand"
        ()
    
    static member getInstance() : CommonStateStrings =
        CommonStateStrings.instance


