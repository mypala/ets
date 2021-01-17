﻿using ResponseStates.Attributes;

namespace ResponseStates.Enums
{
    public enum StateCode
    {
        #region 1xx Informational
        [StateDisplay(Code = 100, Name = "Continue", Message = "Devam et", Success = true)]
        Continue = 100,
        [StateDisplay(Code = 101, Name = "SwitchingProtocols", Message = "Anahtarlama Protokolleri", Success = true)]
        SwitchingProtocols = 101,
        [StateDisplay(Code = 102, Name = "Processing", Message = "İşleme (WebDAV)", Success = true)]
        Processing = 102,
        #endregion

        #region 2xx Success
        [StateDisplay(Code = 200, Name = "OK", Message = "Başarılı", Success = true)]
        OK = 200,
        [StateDisplay(Code = 201, Name = "Created", Message = "Oluşturdu", Success = true)]
        Created = 201,
        [StateDisplay(Code = 202, Name = "Accepted", Message = "Kabul Edildi", Success = true)]
        Accepted = 202,
        [StateDisplay(Code = 203, Name = "NonAuthoritativeInformation", Message = "Yetkilendirilmemiş Bilgi", Success = true)]
        NonAuthoritativeInformation = 203,
        [StateDisplay(Code = 204, Name = "NoContent", Message = "İçerik Yok", Success = true)]
        NoContent = 204,
        [StateDisplay(Code = 205, Name = "ResetContent", Message = "Yenilenmiş İçerik", Success = true)]
        ResetContent = 205,
        [StateDisplay(Code = 206, Name = "PartialContent", Message = "Kısmi İçerik", Success = true)]
        PartialContent = 206,
        [StateDisplay(Code = 207, Name = "MultiStatus", Message = "Çoklu Durum", Success = true)]
        MultiStatus = 207,
        [StateDisplay(Code = 208, Name = "AlreadyReported", Message = "Önceden Bildirilen", Success = true)]
        AlreadyReported = 208,
        [StateDisplay(Code = 209, Name = "IMUsed", Message = "IM Used", Success = true)]
        IMUsed = 226,
        #endregion

        #region 3xx Redirection
        [StateDisplay(Code = 300, Name = "MultipleChoices", Message = "Çoklu Seçim", Success = true)]
        MultipleChoices = 300,
        [StateDisplay(Code = 301, Name = "MovedPermanently", Message = "Kalıcı Olarak Taşındı", Success = true)]
        MovedPermanently = 301,
        [StateDisplay(Code = 302, Name = "Found", Message = "Bulundu", Success = true)]
        Found = 302,
        [StateDisplay(Code = 303, Name = "SeeOther", Message = "Diğerine Bak", Success = true)]
        SeeOther = 303,
        [StateDisplay(Code = 304, Name = "NotModified", Message = "Değiştirilemedi", Success = true)]
        NotModified = 304,
        [StateDisplay(Code = 305, Name = "UseProxy", Message = "Proxy Kullan", Success = true)]
        UseProxy = 305,
        [StateDisplay(Code = 306, Name = "Unused", Message = "Kullanılmamış", Success = true)]
        Unused = 306,
        [StateDisplay(Code = 307, Name = "TemporaryRedirect", Message = "Geçici Yönlendirme", Success = true)]
        TemporaryRedirect = 307,
        [StateDisplay(Code = 308, Name = "PermanentRedirect", Message = "Kalıcı Yönlendirme", Success = true)]
        PermanentRedirect = 308,
        #endregion

        #region 4xx Client Error
        [StateDisplay(Code = 400, Name = "BadRequest", Message = "Hatalı İstek", Success = false)]
        BadRequest = 400,
        [StateDisplay(Code = 401, Name = "Unauthorized", Message = "Yetkisiz", Success = false)]
        Unauthorized = 401,
        [StateDisplay(Code = 402, Name = "PaymentRequired", Message = "Ödeme Gerekli", Success = false)]
        PaymentRequired = 402,
        [StateDisplay(Code = 403, Name = "Forbidden", Message = "Yasaklanmış", Success = false)]
        Forbidden = 403,
        [StateDisplay(Code = 404, Name = "NotFound", Message = "Bulunamadı", Success = false)]
        NotFound = 404,
        [StateDisplay(Code = 405, Name = "MethodNotAllowed", Message = "İzin Verilmeyen Metod", Success = false)]
        MethodNotAllowed = 405,
        [StateDisplay(Code = 406, Name = "NotAcceptable", Message = "Kabul Edilemez", Success = false)]
        NotAcceptable = 406,
        [StateDisplay(Code = 407, Name = "ProxyAuthenticationRequired", Message = "Proxy Kimlik Doğrulaması Gerekli", Success = false)]
        ProxyAuthenticationRequired = 407,
        [StateDisplay(Code = 408, Name = "RequestTimeout", Message = "İstek Zaman Aşımına Uğradı", Success = false)]
        RequestTimeout = 408,
        [StateDisplay(Code = 409, Name = "Conflict", Message = "İstek Çatışması", Success = false)]
        Conflict = 409,
        [StateDisplay(Code = 410, Name = "Gone", Message = "Yok Olmuş - Erişilemez", Success = false)]
        Gone = 410,
        [StateDisplay(Code = 411, Name = "LengthRequired", Message = "İçerik Uzunluğu Gerekli", Success = false)]
        LengthRequired = 411,
        [StateDisplay(Code = 412, Name = "PreconditionFailed", Message = "Önkoşul Başarısız", Success = false)]
        PreconditionFailed = 412,
        [StateDisplay(Code = 413, Name = "RequestEntityTooLarge", Message = "Gönderilen Veri Çok Fazla", Success = false)]
        RequestEntityTooLarge = 413,
        [StateDisplay(Code = 414, Name = "RequestURITooLong", Message = "İstek URL'li Çok Uzun", Success = false)]
        RequestURITooLong = 414,
        [StateDisplay(Code = 415, Name = "UnsupportedMediaType", Message = "Desteklenmeyen Medya Türü", Success = false)]
        UnsupportedMediaType = 415,
        [StateDisplay(Code = 416, Name = "RequestedRangeNotSatisfiable", Message = "İstenen Aralık Uygun Değildir", Success = false)]
        RequestedRangeNotSatisfiable = 416,
        [StateDisplay(Code = 417, Name = "ExpectationFailed", Message = "Beklenti Başarısız oldu", Success = false)]
        ExpectationFailed = 417,
        [StateDisplay(Code = 418, Name = "IMaTeapot", Message = "IMaTeapot", Success = false)]
        IMaTeapot = 418,
        [StateDisplay(Code = 420, Name = "EnhanceYourCalm", Message = "Sakinleştirin", Success = false)]
        EnhanceYourCalm = 420,
        [StateDisplay(Code = 422, Name = "UnprocessableEntity", Message = "İşlenemez Varlık", Success = false)]
        UnprocessableEntity = 422,
        [StateDisplay(Code = 423, Name = "Locked", Message = "Kilitli", Success = false)]
        Locked = 423,
        [StateDisplay(Code = 424, Name = "FailedDependency", Message = "Başarısız Bağımlılık", Success = false)]
        FailedDependency = 424,
        [StateDisplay(Code = 425, Name = "ReservedforWebDAV", Message = "WebDAV için ayrılmıştır", Success = false)]
        ReservedforWebDAV = 425,
        [StateDisplay(Code = 426, Name = "UpgradeRequired", Message = "Yükseltme Gerekli", Success = false)]
        UpgradeRequired = 426,
        [StateDisplay(Code = 428, Name = "PreconditionRequired", Message = "Önkoşul Gerekli", Success = false)]
        PreconditionRequired = 428,
        [StateDisplay(Code = 429, Name = "TooManyRequests", Message = "Çok Fazla İstek", Success = false)]
        TooManyRequests = 429,
        [StateDisplay(Code = 431, Name = "RequestHeaderFieldsTooLarge", Message = "İsteğin Başlık Alanları Çok Büyük", Success = false)]
        RequestHeaderFieldsTooLarge = 431,
        [StateDisplay(Code = 444, Name = "NoResponseNginx", Message = "Nginx Yanıt Vermiyor", Success = false)]
        NoResponseNginx = 444,
        [StateDisplay(Code = 449, Name = "RetryWithMicrosoft", Message = "Microsoft ile yeniden dene", Success = false)]
        RetryWithMicrosoft = 449,
        [StateDisplay(Code = 450, Name = "BlockedByWindowsParentalControls", Message = "Windows Ebeveyn Denetimleri Tarafından Engellendi", Success = false)]
        BlockedByWindowsParentalControls = 450,
        [StateDisplay(Code = 451, Name = "UnavailableForLegalReasons", Message = "Yasal Sebeplerden Dolayı Kullanılamaz", Success = false)]
        UnavailableForLegalReasons = 451,
        [StateDisplay(Code = 499, Name = "ClientClosedRequest", Message = "İstemcinin Kapalı İsteği", Success = false)]
        ClientClosedRequest = 499,
        #endregion

        #region 5xx Server Error
        [StateDisplay(Code = 500, Name = "InternalServerError", Message = "İç Sunucu Hatası", Success = false)]
        InternalServerError = 500,
        [StateDisplay(Code = 501, Name = "NotImplemented", Message = "İsteği Yerine Getiremedi", Success = false)]
        NotImplemented = 501,
        [StateDisplay(Code = 502, Name = "BadGateway", Message = "Hatalı Ağ Geçidi", Success = false)]
        BadGateway = 502,
        [StateDisplay(Code = 503, Name = "ServiceUnavailable", Message = "Sunucu kullanılmaz.", Success = false)]
        ServiceUnavailable = 503,
        [StateDisplay(Code = 504, Name = "GatewayTimeout", Message = "GatewayTimeout", Success = false)]
        GatewayTimeout = 504,
        [StateDisplay(Code = 505, Name = "HTTPVersionNotSupported", Message = "HTTPVersionNotSupported", Success = false)]
        HTTPVersionNotSupported = 505,
        [StateDisplay(Code = 506, Name = "VariantAlsoNegotiates", Message = "VariantAlsoNegotiates", Success = false)]
        VariantAlsoNegotiates = 506,
        [StateDisplay(Code = 507, Name = "InsufficientStorage", Message = "InsufficientStorage", Success = false)]
        InsufficientStorage = 507,
        [StateDisplay(Code = 508, Name = "LoopDetected", Message = "LoopDetected", Success = false)]
        LoopDetected = 508,
        [StateDisplay(Code = 509, Name = "BandwidthLimitExceeded", Message = "BandwidthLimitExceeded", Success = false)]
        BandwidthLimitExceeded = 509,
        [StateDisplay(Code = 510, Name = "NotExtended", Message = "NotExtended", Success = false)]
        NotExtended = 510,
        [StateDisplay(Code = 511, Name = "NetworkAuthenticationRequired", Message = "NetworkAuthenticationRequired", Success = false)]
        NetworkAuthenticationRequired = 511,
        [StateDisplay(Code = 598, Name = "NetworkReadTimeoutError", Message = "NetworkReadTimeoutError", Success = false)]
        NetworkReadTimeoutError = 598,
        [StateDisplay(Code = 599, Name = "NetworkConnectTimeoutError", Message = "NetworkConnectTimeoutError", Success = false)]
        NetworkConnectTimeoutError = 599,
        #endregion


        #region Application Success

        [StateDisplay(Code = 200, SubCode = 20000, Name = "OK", Message = "İşlem Başarılı", Success = true)]
        Success = 20000,

        #region PERSON
        [StateDisplay(Code = 200, SubCode = 20100, Name = "PersonAdd", Message = "Kişi eklendi.", Success = true)]
        PersonAdd = 20100,
        #endregion

        #endregion

        #region Application Errors

        [StateDisplay(Code = 400, SubCode = 40000, Name = "Error", Message = "İşlem Başarısız", Success = false)]
        Error = 40000,
        [StateDisplay(Code = 400, SubCode = 40001, Name = "UnexpectedError", Message = "Beklenilmeyen bir hata ile karşılaşıldığından, işleminiz tamamlanamamıştır.", Success = false)]
        UnexpectedError = 40001,
        [StateDisplay(Code = 400, SubCode = 40002, Name = "ValidationError", Message = "Eksik bilgi ile karşılaşıldığından, işleminiz tamamlanamamıştır.", Success = false)]
        ValidationError = 40002,

        #region PERSON
        [StateDisplay(Code = 400, SubCode = 40100, Name = "PersonNotAdd", Message = "Kişi eklenemedi.", Success = false)]
        PersonNotAdd = 40100,
        [StateDisplay(Code = 400, SubCode = 40101, Name = "PersonNotFound", Message = "Kişi bulunamadı.", Success = false)]
        PersonNotFound = 40101,
        #endregion

        #endregion
    }
}
