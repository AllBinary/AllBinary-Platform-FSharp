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
type InputFeatureFactory =
    [<DefaultValue(false)>] val mutable REMOVE_DUPLICATE_KEY_PRESSES : InputFeature
    [<DefaultValue(false)>] val mutable INPUT_MAPPING : InputFeature
    [<DefaultValue(false)>] val mutable MULTI_KEY_PRESS : InputFeature
    [<DefaultValue(false)>] val mutable SINGLE_KEY_REPEAT_PRESS : InputFeature
    [<DefaultValue(false)>] val mutable SINGLE_KEY_PRESS : InputFeature
    [<DefaultValue(false)>] static val mutable private jcell_instance : InputFeatureFactory
    static member instance with get() : InputFeatureFactory = (InputFeatureFactory.jclinit(); InputFeatureFactory.jcell_instance) and set (jvalue: InputFeatureFactory) = (InputFeatureFactory.jclinit(); InputFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputFeatureFactory.jclinitDone then
            InputFeatureFactory.jclinitDone <- true
            InputFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        InputFeatureFactory.jcell_instance <- (new InputFeatureFactory())
        ()
    member this.jfields_InputFeatureFactory() : unit =
        this.REMOVE_DUPLICATE_KEY_PRESSES <- (new InputFeature("Remove Duplicate Key Presses"))
        this.INPUT_MAPPING <- (new InputFeature("Input Mapping"))
        this.MULTI_KEY_PRESS <- (new InputFeature("Multi Key Press"))
        this.SINGLE_KEY_REPEAT_PRESS <- (new InputFeature("Single Key Repeat Press"))
        this.SINGLE_KEY_PRESS <- (new InputFeature("Single Key Press"))
        ()
    
    static member getInstance() : InputFeatureFactory =
        InputFeatureFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_InputFeatureFactory()
    
    abstract isSingleKeyProcessing : unit -> bool
    default this.isSingleKeyProcessing() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable features : Features = Features.getInstance()
        if features.isFeature(this.SINGLE_KEY_REPEAT_PRESS) || features.isFeature(this.SINGLE_KEY_PRESS) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


