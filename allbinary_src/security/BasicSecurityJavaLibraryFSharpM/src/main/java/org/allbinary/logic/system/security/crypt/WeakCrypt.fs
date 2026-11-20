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
type WeakCrypt =
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable abCrypt : AbCrypt
    [<DefaultValue(false)>] static val mutable private jcell_keys : string[]
    static member keys with get() : string[] = (WeakCrypt.jclinit(); WeakCrypt.jcell_keys) and set (jvalue: string[]) = (WeakCrypt.jclinit(); WeakCrypt.jcell_keys <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_KEYMAX : int
    static member KEYMAX with get() : int = (WeakCrypt.jclinit(); WeakCrypt.jcell_KEYMAX) and set (jvalue: int) = (WeakCrypt.jclinit(); WeakCrypt.jcell_KEYMAX <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WeakCrypt.jclinitDone then
            WeakCrypt.jclinitDone <- true
            WeakCrypt.jclinitBody()
    static member private jclinitBody() : unit =
        WeakCrypt.jcell_keys <- ([| "qwres6qewrupoi1132790jfahleavi89398"; "143uk32lngf8675gt1tv9214uvt924ut9u9"; "12kvjlvlkv11445v12951v512v9m51295v1"; "gampipoiupg4g43y5u238tu2485u20u0932"; "a93u5uu02s2d2g3259u4395u409u093u9vu"; "nlkxzj90je3mln9l8l89qjf0j3v50j23r9j"; "2lk5fn5j23nr8f0233vq35n23jn58vhy843"; "9q24334m598t092tkn2iv0982456n425j9g"; "5m9uvmt9436243m5v34g09d43i52ki35g99"; "n123lr1iubiu2br32lv32rbu23b32ub2rlb"; "va0u0iovji2ojpvj2oij22poiu4ov2uv28v"; "bkk80gn2v9uc902340ut209pcup0u09utc9"; "mn32m32neee23c42fn32nf3mf2n3fn2m3fm"; "zcxpozo3423voizupovsijevnv3n33o33n3"; "v0345324thv93h03893893vh893v8h3vhzz"; "v8na898v8wyef9ty39yv98yaw39yeeyf8ye"; "45zd36d34jg09434hfshp8uj9sy8s7cyr78"; "b098yy0908vdvh983b2lb327980a76s5e5e"; "v90y9v9p8y3r98pagsdgsagyr6y3985yhfh"; "vblkzhhzp8yvzi8u4t9856456zy3rv8a388"; "da7696023rgf28dssfa98asd879hg32hewe"; "afo7d6ffkjb3jr3i34gb24ytuvu3jr3uryf"; "4gijvqo8vq984hv984hj5j3511h832hf833" |] : string[])
        WeakCrypt.jcell_KEYMAX <- WeakCrypt.keys.Length
        ()
    member this.jfields_WeakCrypt() : unit =
        this.tsUtil <- TsUtil.getInstance()
        this.abCrypt <- (new AbCrypt(KeySpecFactory.getInstance_jstatic().DES))
        ()
    
    new (key: int) as this =
        {  }
        then
            this.jfields_WeakCrypt()
            this.jctor1(key)
    member this.jctor1(key: int) : unit =
        try
            this.abCrypt.init(WeakCrypt.keys.[key])
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.putOE(commonStrings.EXCEPTION, this, "SuperCrypt(key)", e)
            | _ -> reraise ()
        ()
    
    abstract encrypt : value: string -> string
    default this.encrypt(value: string) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        try
            let mutable crypted : sbyte[] = this.abCrypt.encrypt(this.tsUtil.getByteArray(value))
            jret <- DatabaseEncoder.encode(crypted)
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE("Encrypt Failed", this, "encrypt", e)
                jret <- StringUtil.getInstance().EMPTY_STRING
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract decrypt : value: string -> string
    default this.decrypt(value: string) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        try
            let mutable decrypted : sbyte[] = this.abCrypt.decrypt(DatabaseEncoder.decode(value))
            jret <- JString.newString(decrypted)
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE("decrypt Failed", this, "decrypt", e)
                jret <- StringUtil.getInstance().EMPTY_STRING
                jflow <- 1
            | _ -> reraise ()
        jret


