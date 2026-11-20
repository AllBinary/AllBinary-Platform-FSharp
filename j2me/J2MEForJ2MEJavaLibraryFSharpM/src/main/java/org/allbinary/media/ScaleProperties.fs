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
type ScaleProperties =
    [<DefaultValue(false)>] val mutable scaleX : float32
    [<DefaultValue(false)>] val mutable scaleY : float32
    [<DefaultValue(false)>] val mutable scaleWidth : int
    [<DefaultValue(false)>] val mutable scaleHeight : int
    [<DefaultValue(false)>] val mutable shouldScale : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScaleProperties
    static member instance with get() : ScaleProperties = (ScaleProperties.jclinit(); ScaleProperties.jcell_instance) and set (jvalue: ScaleProperties) = (ScaleProperties.jclinit(); ScaleProperties.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScaleProperties.jclinitDone then
            ScaleProperties.jclinitDone <- true
            ScaleProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ScaleProperties.jcell_instance <- (new ScaleProperties())
        ()
    new () as this =
        {  }
        then
            this.jfields_ScaleProperties()
    member this.jfields_ScaleProperties() : unit =
        this.scaleX <- 1.0f
        this.scaleY <- 1.0f
        ()
    
    override this.ToString() : string =
        (new StringMaker()).append(CommonLabels.getInstance().COLON_SEP).appendboolean(this.shouldScale).append("scaleX: ").appendfloat(this.scaleX).append("scaleY: ").appendfloat(this.scaleY).append("scaleWidth: ").appendint(this.scaleWidth).append("scaleHeight: ").appendint(this.scaleHeight).ToString()


