﻿namespace authorizenet.apicore.controller
{
    using System;
    using authorizenet.apicore.contract.v1;
    using authorizenet.apicore.controller.bases;

#pragma warning disable 1591
    public class createTransactionController : ApiOperationBase<createTransactionRequest, createTransactionResponse> {

	    public createTransactionController(createTransactionRequest apiRequest) : base(apiRequest) {
	    }

	    override protected void ValidateRequest() {
            var request = GetApiRequest();
		
		    //validate required fields		
		    //if ( 0 == request.SearchType) throw new ArgumentException( "SearchType cannot be null");
		    //if ( null == request.Paging) throw new ArgumentException("Paging cannot be null");
		
		    //validate not-required fields		
	    }

        protected override void BeforeExecute()
        {
            var request = GetApiRequest();
            RequestFactoryWithSpecified.transactionRequestType(request.transactionRequest);
        }
    }
#pragma warning restore 1591
}