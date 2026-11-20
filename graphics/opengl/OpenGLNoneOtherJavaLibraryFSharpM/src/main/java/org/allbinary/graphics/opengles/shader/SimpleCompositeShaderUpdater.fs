namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type SimpleCompositeShaderUpdater =
    inherit CompositeShaderUpdater
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimpleCompositeShaderUpdater.jclinitDone then
            SimpleCompositeShaderUpdater.jclinitDone <- true
            SimpleCompositeShaderUpdater.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (uniformBlockArray: string[], uniformArray: string[], attributeArray: string[], attributeHandleArray: int[]) =
        { inherit CompositeShaderUpdater(uniformBlockArray, uniformArray, attributeArray, attributeHandleArray) }


