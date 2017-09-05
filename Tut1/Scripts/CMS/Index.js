console.log("JS is working bro");

var CMS = (function () {
    var strSectionIDs = [],
        $sectionTopNavLIs = null,
        $sectionArticles = null,
        strEstimateOrderID = null,
        strShoppingCartHeaders = null,
        strCurrentSectionID = null,
        strInventoryItemID = null,
        strShoppingCartItemID = null,
        objTaxRates = null,
        objInventoryList = {},
        objShoppingCartList = {},
        objInventoryPackages = {},
        objValidationFieldIDs = { "order": ["currency-taxRate", "currency-type", "shoppingCart"], "customer": ["personal-title", "personal-gender", "personal-firstName", "personal-lastName", "personal-telephone", "personal-email", "company-company", "company-address", "company-city", "company-provinceState", "company-PostalZip", "company-country", "shipping-name", "shipping-address", "shipping-city", "shipping-provinceState", "shipping-PostalZip", "shipping-country", "invoiceTo"], "billing": ["nameOnCreditCard", "creditCardNumber", "cvvNumber", "creditCardExpiryMonth", "creditCardExpiryYear", "initialsJSON", "signatureJSON"] },
        blnIsBusy = false,
        blnHasOutdatedShoppingCartItem = false,

        initialize = function () {

            console.log("inside the init function");
            $sectionTopNavLIs = $("main").children("nav").children("ul").children("li");
            $sectionArticles = $("form").children("section").children("article");

            strShoppingCartHeaders = $("#shoppingCartList").children("table").children("tbody").html();

            for (var i = 1; i <= $sectionTopNavLIs.length; i++) {
                strSectionIDs.push($sectionTopNavLIs.filter(":nth-child(" + i + ")").children("span").data("sectionid"));
                console.log(strSectionIDs);
                console.log("hi");

            }
            
            $("li").each(function (index) {
                console.log(index + ": " + $(this).text());

              
            });

            

            $("#customerSearch").focus();
        };


    return {
        initialize: initialize
    };
})();
$(document).ready(CMS.initialize);