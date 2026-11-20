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
type BasicCrypt =
    [<DefaultValue(false)>] val mutable byteUtil : ByteUtil
    [<DefaultValue(false)>] val mutable key : sbyte[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicCrypt.jclinitDone then
            BasicCrypt.jclinitDone <- true
            BasicCrypt.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicCrypt() : unit =
        this.byteUtil <- ByteUtil.getInstance()
        ()
    
    new (keyAsString: string) as this =
        {  }
        then
            this.jfields_BasicCrypt()
            this.jctor1(keyAsString)
    member this.jctor1(keyAsString: string) : unit =
        let mutable key : sbyte[] = NullUtil.getInstance().NULL_BYTE_ARRAY
        try
            key <- TsUtil.getInstance().getByteArray(keyAsString)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.putOE(commonStrings.EXCEPTION, this, "AbCrypt(alg,key)", e)
            | _ -> reraise ()
        this.key <- key
        ()
    
    abstract encrypt : array_: sbyte[] -> sbyte[]
    default this.encrypt(array_: sbyte[]) : sbyte[] =
        let mutable jflow = 0
        let mutable jret : sbyte[] = Unchecked.defaultof<sbyte[]>
        try
            jret <- this.mutilate(array_)
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE("Encrypt Failed", this, "encrypt", e)
                jret <- NullUtil.getInstance().NULL_BYTE_ARRAY
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract decrypt : array_: sbyte[] -> sbyte[]
    default this.decrypt(array_: sbyte[]) : sbyte[] =
        let mutable jflow = 0
        let mutable jret : sbyte[] = Unchecked.defaultof<sbyte[]>
        try
            jret <- this.mutilate(array_)
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE("decrypt Failed", this, "decrypt", e)
                jret <- NullUtil.getInstance().NULL_BYTE_ARRAY
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract mutilate : array_: sbyte[] -> sbyte[]
    default this.mutilate(array_: sbyte[]) : sbyte[] =
        let mutable array_ = array_
        let mutable value : sbyte = 0y
        let mutable index : int = 0
        while index < this.key.Length do
            value <- this.key.[index]
            array_ <- this.byteUtil.xor(array_, value)
            index <- index + 1
        array_
    interface CryptInterface with
        member this.encrypt(jp0: sbyte[]) : sbyte[] = this.encrypt(jp0)
        member this.decrypt(jp0: sbyte[]) : sbyte[] = this.decrypt(jp0)


