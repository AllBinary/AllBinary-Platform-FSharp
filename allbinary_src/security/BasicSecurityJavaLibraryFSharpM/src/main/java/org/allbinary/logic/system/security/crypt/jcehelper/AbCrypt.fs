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
type AbCrypt =
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable secretComposite : BaseSecretComposite
    [<DefaultValue(false)>] val mutable algorithm : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbCrypt.jclinitDone then
            AbCrypt.jclinitDone <- true
            AbCrypt.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AbCrypt() : unit =
        this.tsUtil <- TsUtil.getInstance()
        this.secretComposite <- BaseSecretComposite.NULL_SECRET_COMPOSITE
        ()
    
    new (algorithm: string) as this =
        {  }
        then
            this.jfields_AbCrypt()
            this.jctor1(algorithm)
    member this.jctor1(algorithm: string) : unit =
        this.algorithm <- algorithm
        ()
    
    abstract init : keyAsString: string -> unit
    default this.init(keyAsString: string) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        try
            try
                ignore (Security.addProvider((new BouncyCastleProvider())))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    PreLogUtil.putOE(commonStrings.EXCEPTION, this, commonStrings.INIT, e)
                | _ -> reraise ()
            let mutable key : sbyte[] = this.tsUtil.getByteArray(keyAsString)
            let mutable keySpec : KeySpec = KeySpecFactory.getInstance_jstatic().getInstance(this.algorithm, key)
            let mutable keyFactory : SecretKeyFactory = SecretKeyFactory.getInstance(this.algorithm)
            let mutable secretKey : SecretKey = keyFactory.generateSecret(keySpec)
            let mutable cipher : Cipher = Cipher.getInstance(this.algorithm)
            this.secretComposite <- (new SecretComposite(secretKey, cipher, key))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE("init Failed", this, commonStrings.INIT, e)
            | _ -> reraise ()
    
    abstract encrypt : array_: sbyte[] -> sbyte[]
    default this.encrypt(array_: sbyte[]) : sbyte[] =
        let mutable jflow = 0
        let mutable jret : sbyte[] = Unchecked.defaultof<sbyte[]>
        try
            jret <- this.secretComposite.encrypt(array_)
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
            jret <- this.secretComposite.decrypt(array_)
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE("decrypt Failed", this, "decrypt", e)
                jret <- NullUtil.getInstance().NULL_BYTE_ARRAY
                jflow <- 1
            | _ -> reraise ()
        jret
    interface CryptInterface with
        member this.encrypt(jp0: sbyte[]) : sbyte[] = this.encrypt(jp0)
        member this.decrypt(jp0: sbyte[]) : sbyte[] = this.decrypt(jp0)


