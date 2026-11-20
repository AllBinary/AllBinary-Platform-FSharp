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
type AnimationFactoryInitializationVisitor =
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable originalDx : int
    [<DefaultValue(false)>] val mutable originalDy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationFactoryInitializationVisitor.jclinitDone then
            AnimationFactoryInitializationVisitor.jclinitDone <- true
            AnimationFactoryInitializationVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract visit : unit -> unit
    default this.visit() : unit =
        ()
    
    override this.ToString() : string =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(PositionStrings.getInstance().DX_LABEL).appendfloat(float32 (this.dx)))
        ignore (stringBuffer.append(PositionStrings.getInstance().DY_LABEL).appendfloat(float32 (this.dy)))
        ignore (stringBuffer.append(commonLabels.WIDTH_LABEL))
        ignore (stringBuffer.appendint(this.width))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(commonLabels.HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.height))
        stringBuffer.ToString()


