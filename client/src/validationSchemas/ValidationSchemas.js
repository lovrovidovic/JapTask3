import * as Yup from 'yup';

export const IngredientSchema = Yup.object().shape({
    name: Yup.string()
        .required('Name is required')
        .min(3),
    normativeQuantity: Yup.number()
        .required('Normative quantity is required')
        .min(1),
    normativePrice: Yup.number()
        .required('Normative price is required')
        .min(1),
    normativeUnit: Yup.string()
        .required('Normative unit is required')
});

export const CategorySchema = Yup.object().shape({
    name: Yup.string()
        .required('Name is required')
        .min(3)
});

export const RecipeSchema = Yup.object().shape({
    name: Yup.string()
        .required('Name is required')
        .min(3),
    description: Yup.string()
        .required('Description is required'),
    categoryId: Yup.number()
        .required('Category must be selected'),
    recommendedPrice: Yup.number()
        .required('Recommended price is required')
        .min(0)
});

