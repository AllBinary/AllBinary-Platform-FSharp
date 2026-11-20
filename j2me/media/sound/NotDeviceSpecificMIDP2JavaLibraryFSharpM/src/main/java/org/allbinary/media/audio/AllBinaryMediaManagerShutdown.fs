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
type AllBinaryMediaManagerShutdown =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AllBinaryMediaManagerShutdown
    static member instance with get() : AllBinaryMediaManagerShutdown = (AllBinaryMediaManagerShutdown.jclinit(); AllBinaryMediaManagerShutdown.jcell_instance) and set (jvalue: AllBinaryMediaManagerShutdown) = (AllBinaryMediaManagerShutdown.jclinit(); AllBinaryMediaManagerShutdown.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryMediaManagerShutdown.jclinitDone then
            AllBinaryMediaManagerShutdown.jclinitDone <- true
            AllBinaryMediaManagerShutdown.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryMediaManagerShutdown.jcell_instance <- (new AllBinaryMediaManagerShutdown())
        ()
    new () =
        {  }
    
    static member shutdown(soundsFactoryInterface: SoundsFactoryInterface) : unit =
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        logUtil.putF(commonStrings.START, AllBinaryMediaManagerShutdown.instance, "shutdown")
        AllBinaryMediaManager.shutdown(soundsFactoryInterface)


