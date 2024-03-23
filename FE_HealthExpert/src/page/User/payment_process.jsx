import React from "react";
import {
    useNavigate
} from "react-router-dom";
import Header from "../../components/Header_user";

function PaymentProcess() {
    var link = "https://en.wikipedia.org";

    return (
        <>
            <base href="./" />
            <meta charSet="utf-8" />
            <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
            <Header />

            <div className="relative flex h-screen font-[sans-serif]" id="paymentForm">
                <div className="m-auto">
                    <div className="bg-white border-2 rounded-lg drop-shadow-lg w-90">
                        <div className="p-4">
                            {/* Account ID */}
                            <div className="flex">
                                <div className="w-1/5">
                                    <p className="mb-5">Account ID:</p>
                                </div>
                                <div className="w-4/5">
                                    <p className="mb-5 font-bold text-right">
                                        sdsauiy320-clksajd
                                    </p>
                                </div>
                            </div>
                            {/* Course */}
                            <div className="flex">
                                <div className="w-1/5">
                                    <p className="mb-5">Khóa học:</p>
                                </div>
                                <div className="w-4/5">
                                    <p className="mb-5 font-bold text-right">
                                    At the Academy Awards, Oppenheimer wins seven awards, including Best Picture.
                                    </p>
                                </div>
                            </div>
                            <hr />
                            {/* Cost? */}
                            <div className="flex">
                                <div className="w-1/5">
                                    <p className="mt-5">Giá Tiền:</p>
                                </div>
                                <div className="w-4/5">
                                    <p className="mt-5 text-orange-400 text-3xl font-bold text-right">
                                        300000đ
                                    </p>
                                </div>
                            </div>
                            <button
                                type="button"
                                className="text-black bg-orange-400 hover:bg-orange-600 hover:text-white hover:border-white hover:fill-white border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded w-full h-10 py-1 text-center mt-8"
                                onClick={(e) => {
                                    e.preventDefault();
                                    link = "https://en.wikipedia.org"
                                    window.location.href = link;
                                    }}
                            >
                                <span className=" ml-1 align-middle inline-block">Thanh Toán</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div className="mt-auto">
                <footer className="bg-white">
                    <br />
                    <hr />
                    <br />
                    <div>HealtExpert © 2024</div>
                </footer>
            </div>
        </>
    );
};

export default PaymentProcess;