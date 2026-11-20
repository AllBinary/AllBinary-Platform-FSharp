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
type PCGameInputMapping =
    inherit PersistentInputMapping
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PCGameInputMapping.jclinitDone then
            PCGameInputMapping.jclinitDone <- true
            PCGameInputMapping.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit PersistentInputMapping(GamePersistanceStrings.getInstance().SAVED_INPUT_CONFIGURATION_RECORD_ID) }
    
    override this.init(abeClientInformation: AbeClientInformationInterface) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.INIT)
        ignore (PCKeyFactory.getInstance())
        ignore (TouchMotionGestureFactory.getInstance())
        ignore (TrackballMotionGestureFactory.getInstance())
        ignore (BasicTouchInputFactory.getInstance())
        base.init(abeClientInformation)
        if (this.getTotalMapped() = 0) || this.isDefaultNew() then
            this.getInputMapping().addMapping(this.getDefault())
            this.save(abeClientInformation)
    
    override this.isDelete(input: Input) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(input, PCKeyFactory.getInstance().DEL)) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    override this.isSystemInput(input: Input) : bool =
        false


