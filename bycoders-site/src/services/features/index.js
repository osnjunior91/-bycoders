import { BycodersApi } from "../axios";

const GetTransactions = () => {
    return BycodersApi.get('/transaction/store/all');
}

export { GetTransactions }