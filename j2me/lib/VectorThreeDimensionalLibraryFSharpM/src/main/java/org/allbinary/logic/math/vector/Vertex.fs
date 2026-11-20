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
type Vertex =
    [<DefaultValue(false)>] val mutable x : BasicDecimal
    [<DefaultValue(false)>] val mutable y : BasicDecimal
    [<DefaultValue(false)>] val mutable z : BasicDecimal
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Vertex.jclinitDone then
            Vertex.jclinitDone <- true
            Vertex.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Vertex() : unit =
        this.x <- (new BasicDecimal(0L))
        this.y <- (new BasicDecimal(0L))
        this.z <- (new BasicDecimal(0L))
        ()
    
    new () as this =
        {  }
        then
            this.jfields_Vertex()
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable positionStrings : PositionStrings = PositionStrings.getInstance()
        ignore (stringBuffer.append(positionStrings.X_LABEL))
        ignore (stringBuffer.append(this.x.ToString()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(positionStrings.Y_LABEL))
        ignore (stringBuffer.append(this.y.ToString()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(positionStrings.Z_LABEL))
        ignore (stringBuffer.append(this.z.ToString()))
        stringBuffer.ToString()


