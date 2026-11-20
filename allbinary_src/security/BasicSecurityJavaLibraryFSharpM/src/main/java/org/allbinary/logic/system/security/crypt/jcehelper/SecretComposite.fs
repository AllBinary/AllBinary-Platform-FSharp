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
type SecretComposite =
    inherit BaseSecretComposite
    [<DefaultValue(false)>] val mutable byteUtil : ByteUtil
    [<DefaultValue(false)>] val mutable cipher : Cipher
    [<DefaultValue(false)>] val mutable secretKey : SecretKey
    [<DefaultValue(false)>] val mutable key : sbyte[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SecretComposite.jclinitDone then
            SecretComposite.jclinitDone <- true
            SecretComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_SecretComposite() : unit =
        this.byteUtil <- ByteUtil.getInstance()
        ()
    
    new (secretKey: SecretKey, cipher: Cipher, key: sbyte[]) as this =
        { inherit BaseSecretComposite() }
        then
            this.jfields_SecretComposite()
            this.jctor1(secretKey, cipher, key)
    member this.jctor1(secretKey: SecretKey, cipher: Cipher, key: sbyte[]) : unit =
        this.secretKey <- secretKey
        this.cipher <- cipher
        this.key <- key
        ()
    
    override this.encrypt(array_: sbyte[]) : sbyte[] =
        let mutable array_ = array_
        array_ <- this.mutilate(array_)
        ignore (this.cipher.init(Cipher.ENCRYPT_MODE, this.secretKey))
        this.cipher.doFinal(array_)
    
    override this.decrypt(array_: sbyte[]) : sbyte[] =
        ignore (this.cipher.init(Cipher.DECRYPT_MODE, this.secretKey))
        this.mutilate(this.cipher.doFinal(array_))
    
    member this.mutilate(array_: sbyte[]) : sbyte[] =
        let mutable array_ = array_
        let mutable index : int = 0
        while index < this.key.Length do
            let mutable value : sbyte = this.key.[index]
            if (int (int (value)) < 8) && (int (int (value)) > 0) then
                array_ <- this.byteUtil.xorByte(array_, int (value))
            index <- index + 1
        array_


